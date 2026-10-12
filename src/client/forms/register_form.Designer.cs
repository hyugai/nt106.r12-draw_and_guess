#nullable enable

namespace client.forms;

partial class RegisterForm
{
    private System.ComponentModel.IContainer? components = null;

    private Label lblLoiTenDangNhap = null!;
    private Label lblLoiHoTen = null!;
    private Label lblLoiEmailSdt = null!;
    private Label lblLoiMatKhau = null!;
    private Label lblLoiXacNhan = null!;
    private Label lblTieuDe = null!;

    private Label label1 = null!;
    private Label label2 = null!;
    private Label label3 = null!;
    private Label label4 = null!;
    private Label label5 = null!;

    private TextBox txtTenDangNhap = null!;
    private TextBox txtHoTen = null!;
    private TextBox txtEmailSdt = null!;
    private TextBox txtMatKhau = null!;
    private TextBox txtXacNhanMatKhau = null!;

    private Button btnDangKy = null!;
    private Button btnHuy = null!;
    private Button btnDangNhap = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTieuDe = new Label();

        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();

        txtTenDangNhap = new TextBox();
        txtHoTen = new TextBox();
        txtEmailSdt = new TextBox();
        txtMatKhau = new TextBox();
        txtXacNhanMatKhau = new TextBox();

        lblLoiTenDangNhap = new Label();
        lblLoiHoTen = new Label();
        lblLoiEmailSdt = new Label();
        lblLoiMatKhau = new Label();
        lblLoiXacNhan = new Label();

        btnDangKy = new Button();
        btnHuy = new Button();
        btnDangNhap = new Button();

        SuspendLayout();

        // Title
        lblTieuDe.Font = new Font(
            "Segoe UI", 16F, FontStyle.Bold
        );
        lblTieuDe.Location = new Point(255, 23);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(430, 45);
        lblTieuDe.Text = "ĐĂNG KÝ";
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

        // Username
        label1.AutoSize = true;
        label1.Location = new Point(217, 117);
        label1.Text = "Tài khoản";

        txtTenDangNhap.Location = new Point(309, 114);
        txtTenDangNhap.Name = "txtTenDangNhap";
        txtTenDangNhap.MaxLength = 20;
        txtTenDangNhap.Size = new Size(396, 31);
        txtTenDangNhap.TabIndex = 0;

        lblLoiTenDangNhap.ForeColor = Color.Red;
        lblLoiTenDangNhap.Location = new Point(309, 148);
        lblLoiTenDangNhap.Size = new Size(480, 29);
        lblLoiTenDangNhap.Name = "lblLoiTenDangNhap";

        // Full name
        label4.AutoSize = true;
        label4.Location = new Point(217, 185);
        label4.Text = "Họ tên";

        txtHoTen.Location = new Point(309, 182);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.MaxLength = 50;
        txtHoTen.Size = new Size(396, 31);
        txtHoTen.TabIndex = 1;

        lblLoiHoTen.ForeColor = Color.Red;
        lblLoiHoTen.Location = new Point(309, 216);
        lblLoiHoTen.Size = new Size(480, 29);
        lblLoiHoTen.Name = "lblLoiHoTen";

        // Email
        label5.AutoSize = true;
        label5.Location = new Point(217, 253);
        label5.Text = "Email";

        txtEmailSdt.Location = new Point(309, 250);
        txtEmailSdt.Name = "txtEmailSdt";
        txtEmailSdt.MaxLength = 100;
        txtEmailSdt.Size = new Size(396, 31);
        txtEmailSdt.TabIndex = 2;

        lblLoiEmailSdt.ForeColor = Color.Red;
        lblLoiEmailSdt.Location = new Point(309, 284);
        lblLoiEmailSdt.Size = new Size(480, 29);
        lblLoiEmailSdt.Name = "lblLoiEmailSdt";

        // Password
        label2.AutoSize = true;
        label2.Location = new Point(217, 321);
        label2.Text = "Mật khẩu";

        txtMatKhau.Location = new Point(309, 318);
        txtMatKhau.Name = "txtMatKhau";
        txtMatKhau.Size = new Size(396, 31);
        txtMatKhau.TabIndex = 3;
        txtMatKhau.UseSystemPasswordChar = true;

        lblLoiMatKhau.ForeColor = Color.Red;
        lblLoiMatKhau.Location = new Point(309, 352);
        lblLoiMatKhau.Size = new Size(480, 29);
        lblLoiMatKhau.Name = "lblLoiMatKhau";

        // Confirm password
        label3.AutoSize = true;
        label3.Location = new Point(147, 389);
        label3.Text = "Nhập lại mật khẩu";

        txtXacNhanMatKhau.Location = new Point(309, 386);
        txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
        txtXacNhanMatKhau.Size = new Size(396, 31);
        txtXacNhanMatKhau.TabIndex = 4;
        txtXacNhanMatKhau.UseSystemPasswordChar = true;

        lblLoiXacNhan.ForeColor = Color.Red;
        lblLoiXacNhan.Location = new Point(309, 420);
        lblLoiXacNhan.Size = new Size(480, 29);
        lblLoiXacNhan.Name = "lblLoiXacNhan";

        // Register button
        btnDangKy.Location = new Point(468, 467);
        btnDangKy.Name = "btnDangKy";
        btnDangKy.Size = new Size(112, 34);
        btnDangKy.TabIndex = 5;
        btnDangKy.Text = "Đăng ký";
        btnDangKy.UseVisualStyleBackColor = true;
        btnDangKy.Click += register_button_Click;

        // Cancel button
        btnHuy.Location = new Point(606, 467);
        btnHuy.Name = "btnHuy";
        btnHuy.Size = new Size(112, 34);
        btnHuy.TabIndex = 6;
        btnHuy.Text = "Huỷ";
        btnHuy.UseVisualStyleBackColor = true;
        btnHuy.Click += cancel_button_Click;

        // Login button
        btnDangNhap.Location = new Point(760, 467);
        btnDangNhap.Name = "btnDangNhap";
        btnDangNhap.Size = new Size(112, 34);
        btnDangNhap.TabIndex = 7;
        btnDangNhap.Text = "Đăng nhập";
        btnDangNhap.UseVisualStyleBackColor = true;
        btnDangNhap.Click += login_button_Click;

        // RegisterForm
        AcceptButton = btnDangKy;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(898, 550);

        Controls.Add(lblTieuDe);

        Controls.Add(label1);
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(label4);
        Controls.Add(label5);

        Controls.Add(txtTenDangNhap);
        Controls.Add(txtHoTen);
        Controls.Add(txtEmailSdt);
        Controls.Add(txtMatKhau);
        Controls.Add(txtXacNhanMatKhau);

        Controls.Add(lblLoiTenDangNhap);
        Controls.Add(lblLoiHoTen);
        Controls.Add(lblLoiEmailSdt);
        Controls.Add(lblLoiMatKhau);
        Controls.Add(lblLoiXacNhan);

        Controls.Add(btnDangKy);
        Controls.Add(btnHuy);
        Controls.Add(btnDangNhap);

        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "RegisterForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đăng ký tài khoản";

        ResumeLayout(false);
        PerformLayout();
    }
}

