namespace QuanLyNguoiDung
{
    partial class formDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLoiTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtMatKhau = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            txtEmailSdt = new TextBox();
            lblLoiMatKhau = new Label();
            lblLoiXacNhan = new Label();
            lblLoiEmailSdt = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            lblTieuDe = new Label();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // lblLoiTenDangNhap
            // 
            lblLoiTenDangNhap.ForeColor = Color.Red;
            lblLoiTenDangNhap.Location = new Point(309, 151);
            lblLoiTenDangNhap.Name = "lblLoiTenDangNhap";
            lblLoiTenDangNhap.Size = new Size(396, 29);
            lblLoiTenDangNhap.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(309, 117);
            txtTenDangNhap.MaxLength = 20;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(396, 31);
            txtTenDangNhap.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 117);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 11;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 257);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 12;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 321);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 13;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 189);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 15;
            label5.Text = "Email hoặc SDT";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(309, 254);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(396, 31);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(309, 321);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(396, 31);
            txtXacNhanMatKhau.TabIndex = 3;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // txtEmailSdt
            // 
            txtEmailSdt.Location = new Point(309, 186);
            txtEmailSdt.MaxLength = 100;
            txtEmailSdt.Name = "txtEmailSdt";
            txtEmailSdt.Size = new Size(396, 31);
            txtEmailSdt.TabIndex = 1;
            // 
            // lblLoiMatKhau
            // 
            lblLoiMatKhau.ForeColor = Color.Red;
            lblLoiMatKhau.Location = new Point(309, 288);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(396, 30);
            lblLoiMatKhau.TabIndex = 20;
            lblLoiMatKhau.Click += lblLoiMatKhau_Click;
            // 
            // lblLoiXacNhan
            // 
            lblLoiXacNhan.ForeColor = Color.Red;
            lblLoiXacNhan.Location = new Point(309, 355);
            lblLoiXacNhan.Name = "lblLoiXacNhan";
            lblLoiXacNhan.Size = new Size(396, 31);
            lblLoiXacNhan.TabIndex = 21;
            // 
            // lblLoiEmailSdt
            // 
            lblLoiEmailSdt.ForeColor = Color.Red;
            lblLoiEmailSdt.Location = new Point(309, 217);
            lblLoiEmailSdt.Name = "lblLoiEmailSdt";
            lblLoiEmailSdt.Size = new Size(396, 34);
            lblLoiEmailSdt.TabIndex = 23;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(468, 397);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(112, 34);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(606, 397);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(255, 23);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(430, 45);
            lblTieuDe.TabIndex = 24;
            lblTieuDe.Text = "ĐĂNG KÝ";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(760, 397);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(112, 34);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // formDangKy
            // 
            AcceptButton = btnDangKy;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 490);
            Controls.Add(btnDangNhap);
            Controls.Add(lblTieuDe);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(lblLoiEmailSdt);
            Controls.Add(lblLoiXacNhan);
            Controls.Add(lblLoiMatKhau);
            Controls.Add(txtEmailSdt);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblLoiTenDangNhap);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "formDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLoiTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMatKhau;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtEmailSdt;
        private Label lblLoiMatKhau;
        private Label lblLoiXacNhan;
        private Label lblLoiHoTen;
        private Label lblLoiEmailSdt;
        private Button btnDangKy;
        private Button btnHuy;
        private Label lblTieuDe;
        private Button btnDangNhap;
    }
}