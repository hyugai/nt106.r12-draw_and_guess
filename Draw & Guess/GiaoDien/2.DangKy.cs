using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Draw___Guess
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static class MatKhau
        {
            private const int VONG_LAP = 600_000;

            // Goi khi dang ky 
            public static (string Salt, string Bam) Tao(string matKhau)
            {
                byte[] salt = RandomNumberGenerator.GetBytes(16);
                byte[] bam = Rfc2898DeriveBytes.Pbkdf2(
                    matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256, 32);
                return (Convert.ToBase64String(salt), Convert.ToBase64String(bam));
            }

            // Goi khi dang nhap 
            public static bool KiemTra(string matKhau, string saltLuu, string bamLuu)
            {
                byte[] salt = Convert.FromBase64String(saltLuu);
                byte[] bamCu = Convert.FromBase64String(bamLuu);
                byte[] bamMoi = Rfc2898DeriveBytes.Pbkdf2(
                    matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256, 32);
                return CryptographicOperations.FixedTimeEquals(bamCu, bamMoi);
            }
        }

    }
}
