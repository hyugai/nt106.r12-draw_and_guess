using System.Security.Cryptography;

namespace auth.services;

public static class PasswordHasher
{
    private const int Iterations = 600_000;
    private const int SaltSize = 16;
    private const int HashSize = 32;

    public static (string Hash, string Salt) HashPassword(
        string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);

        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
            password,
            salt,
            Iterations,
            HashAlgorithmName.SHA256,
            HashSize
        );

        return (
            Convert.ToHexString(hash),
            Convert.ToHexString(salt)
        );
    }

    public static bool VerifyPassword(
        string password,
        string storedHash,
        string storedSalt)
    {
        byte[] salt = Convert.FromHexString(storedSalt);
        byte[] expectedHash = Convert.FromHexString(storedHash);

        if (salt.Length != SaltSize ||
            expectedHash.Length != HashSize)
        {
            return false;
        }

        byte[] actualHash = Rfc2898DeriveBytes.Pbkdf2(
            password,
            salt,
            Iterations,
            HashAlgorithmName.SHA256,
            HashSize
        );

        return CryptographicOperations.FixedTimeEquals(
            actualHash,
            expectedHash
        );
    }
}

