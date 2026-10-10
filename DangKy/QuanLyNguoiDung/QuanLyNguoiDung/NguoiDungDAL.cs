using Microsoft.Data.SqlClient;
using System.Data;

public enum KetQuaThem { ThanhCong, TrungTenDangNhap, TrungLienHe }

public class NguoiDungDAL
{
    private const string ChuoiKetNoi =
        @"Server=localhost;Database=QuanLyNguoiDung;" +
        @"Trusted_Connection=True;TrustServerCertificate=True;";

    private async Task<bool> TonTai(string cot, string giaTri, int doDai)
    {
        string sql = "SELECT COUNT(1) FROM Users WHERE " + cot + " = @giaTri";
        using var conn = new SqlConnection(ChuoiKetNoi);
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.Add("@giaTri", SqlDbType.NVarChar, doDai).Value = giaTri;
        await conn.OpenAsync();
        object ketQua = await cmd.ExecuteScalarAsync();
        return Convert.ToInt32(ketQua) > 0;
    }

    public Task<bool> TonTaiTenDangNhap(string ten)
    {
        return TonTai("TenDangNhap", ten, 20);
    }

    public Task<bool> TonTaiLienHe(string lienHe)
    {
        return TonTai("LienHe", lienHe, 100);
    }

    public async Task<KetQuaThem> ThemNguoiDung(
        string ten, string lienHe, string bam, string salt)
    {
        const string sql =
            "INSERT INTO Users (TenDangNhap, LienHe, MatKhauBam, Salt) " +
            "VALUES (@ten, @lienHe, @bam, @salt)";
        using var conn = new SqlConnection(ChuoiKetNoi);
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = ten;
        cmd.Parameters.Add("@lienHe", SqlDbType.NVarChar, 100).Value = lienHe;
        cmd.Parameters.Add("@bam", SqlDbType.NVarChar, 64).Value = bam;
        cmd.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value = salt;
        try
        {
            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
            return KetQuaThem.ThanhCong;
        }
        catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
        {
            if (ex.Message.Contains("UQ_Users_LienHe"))
                return KetQuaThem.TrungLienHe;
            return KetQuaThem.TrungTenDangNhap;
        }
    }
}
