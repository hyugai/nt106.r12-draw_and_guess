using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
namespace QuanLyNguoiDung
{
    public partial class formDangKy : Form
    {
        public formDangKy()
        {
            InitializeComponent();
        }

        private void lblLoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private readonly NguoiDungDAL dal = new NguoiDungDAL();

        private const int TK_TOI_THIEU = 4;
        private const int TK_TOI_DA = 20;
        private const int MK_TOI_THIEU = 6;

        private static readonly Regex RegexTaiKhoan = new(@"^[A-Za-z0-9_]+\z");
        private static readonly Regex RegexEmail = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+\z");
        private static readonly Regex RegexSdt = new(@"^0\d{9}\z");

        private void XoaLoi()
        {
            lblLoiTenDangNhap.Text = "";
            lblLoiEmailSdt.Text = "";
            lblLoiMatKhau.Text = "";
            lblLoiXacNhan.Text = "";
        }

        private bool KiemTraDuLieu()
        {
            bool hopLe = true;
            Control oLoiDau = null;

            void Loi(Label lbl, Control o, string nd)
            {
                lbl.Text = nd;
                hopLe = false;
                oLoiDau ??= o;
            }

            string ten = txtTenDangNhap.Text.Trim();
            if (ten.Length == 0)
                Loi(lblLoiTenDangNhap, txtTenDangNhap, "Vui lòng nhập tài khoản");
            else if (ten.Length < TK_TOI_THIEU)
                Loi(lblLoiTenDangNhap, txtTenDangNhap, "Tài khoản phải có ít nhất 4 ký tự");
            else if (ten.Length > TK_TOI_DA)
                Loi(lblLoiTenDangNhap, txtTenDangNhap, "Tài khoản không được vượt quá 20 ký tự");
            else if (!RegexTaiKhoan.IsMatch(ten))
                Loi(lblLoiTenDangNhap, txtTenDangNhap, "Tài khoản chỉ được chứa chữ, số và dấu gạch dưới");
            else if (char.IsDigit(ten[0]))
                Loi(lblLoiTenDangNhap, txtTenDangNhap, "Tài khoản không được bắt đầu bằng số");

            string lienHe = txtEmailSdt.Text.Trim();
            if (lienHe.Length == 0)
            {
                Loi(lblLoiEmailSdt, txtEmailSdt, "Vui lòng nhập email hoặc số điện thoại");
            }
            else if (!RegexEmail.IsMatch(lienHe) && !RegexSdt.IsMatch(lienHe))
            {
                string nd;
                if (lienHe.Contains('@')) nd = "Email không hợp lệ";
                else if (lienHe.All(char.IsDigit)) nd = "Số điện thoại không hợp lệ";
                else nd = "Vui lòng nhập đúng định dạng email hoặc số điện thoại";
                Loi(lblLoiEmailSdt, txtEmailSdt, nd);
            }

            string mk = txtMatKhau.Text;
            if (mk.Length == 0)
                Loi(lblLoiMatKhau, txtMatKhau, "Vui lòng nhập mật khẩu");
            else if (mk.Length < MK_TOI_THIEU)
                Loi(lblLoiMatKhau, txtMatKhau, "Mật khẩu phải có ít nhất 6 ký tự");
            else if (!mk.Any(char.IsUpper))
                Loi(lblLoiMatKhau, txtMatKhau, "Mật khẩu cần ít nhất 1 chữ in hoa");
            else if (!mk.Any(char.IsDigit))
                Loi(lblLoiMatKhau, txtMatKhau, "Mật khẩu cần ít nhất 1 chữ số");
            else if (mk.Any(char.IsWhiteSpace))
                Loi(lblLoiMatKhau, txtMatKhau, "Mật khẩu không được chứa khoảng trắng");

            string xn = txtXacNhanMatKhau.Text;
            if (xn.Length == 0)
            {
                Loi(lblLoiXacNhan, txtXacNhanMatKhau, "Vui lòng nhập lại mật khẩu");
            }
            else if (xn != mk)
            {
                Loi(lblLoiXacNhan, txtMatKhau, "Mật khẩu xác nhận không khớp");
                txtMatKhau.Clear();
                txtXacNhanMatKhau.Clear();
            }

            oLoiDau?.Focus();
            return hopLe;
        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            XoaLoi();
            if (!KiemTraDuLieu()) return;

            string chuCu = btnDangKy.Text;
            btnDangKy.Enabled = false;
            btnDangKy.Text = "Đang xử lý...";
            bool thanhCong = false;

            try
            {
                string ten = txtTenDangNhap.Text.Trim();
                string lienHe = txtEmailSdt.Text.Trim().ToLowerInvariant();

                bool trungTen = await dal.TonTaiTenDangNhap(ten);
                bool trungLienHe = await dal.TonTaiLienHe(lienHe);
                if (trungTen) lblLoiTenDangNhap.Text = "Tài khoản này đã được sử dụng";
                if (trungLienHe) lblLoiEmailSdt.Text = "Email/Số điện thoại này đã được sử dụng";
                if (trungTen || trungLienHe)
                {
                    if (trungTen) txtTenDangNhap.Focus();
                    else txtEmailSdt.Focus();
                    return;
                }

                string matKhau = txtMatKhau.Text;
                var (salt, bam) = await Task.Run(() => MatKhau.Tao(matKhau));

                var kq = await dal.ThemNguoiDung(ten, lienHe, bam, salt);
                if (kq == KetQuaThem.TrungTenDangNhap)
                {
                    lblLoiTenDangNhap.Text = "Tài khoản này đã được sử dụng";
                    txtTenDangNhap.Focus();
                    return;
                }
                if (kq == KetQuaThem.TrungLienHe)
                {
                    lblLoiEmailSdt.Text = "Email/Số điện thoại này đã được sử dụng";
                    txtEmailSdt.Focus();
                    return;
                }

                thanhCong = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối được máy chủ. Vui lòng thử lại.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = chuCu;
            }

            if (thanhCong)
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnHuy_Click(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaLoi();
            txtTenDangNhap.Clear();
            txtEmailSdt.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();
            txtTenDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đăng nhập do thành viên khác phụ trách.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
