namespace client.forms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnQuenMatKhau = new Button();
            btnDangNhap = new Button();
            label1 = new Label();
            label2 = new Label();
            btnDangKy = new Button();
            checkBox1 = new CheckBox();
            txtMatKhau = new TextBox();
            txtDangNhap = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnQuenMatKhau
            // 
            btnQuenMatKhau.Location = new Point(532, 214);
            btnQuenMatKhau.Name = "btnQuenMatKhau";
            btnQuenMatKhau.Size = new Size(131, 46);
            btnQuenMatKhau.TabIndex = 3;
            btnQuenMatKhau.Text = "Quên mật khẩu?";
            btnQuenMatKhau.UseVisualStyleBackColor = true;
            btnQuenMatKhau.Click += btnQuenMatKhau_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(371, 313);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(131, 46);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(31, 133);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 7;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(31, 224);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu";
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(532, 313);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(131, 46);
            btnDangKy.TabIndex = 10;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(140, 276);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Ghi nhớ tôi";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(140, 221);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(361, 34);
            txtMatKhau.TabIndex = 13;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtDangNhap
            // 
            txtDangNhap.Font = new Font("Segoe UI", 12F);
            txtDangNhap.Location = new Point(140, 130);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(361, 34);
            txtDangNhap.TabIndex = 14;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 2;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 1;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(238, 38);
            label3.Name = "label3";
            label3.Size = new Size(200, 41);
            label3.TabIndex = 15;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // LoginForm
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(692, 431);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(checkBox1);
            Controls.Add(btnDangKy);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangNhap);
            Controls.Add(btnQuenMatKhau);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnQuenMatKhau;
        private Button btnDangNhap;
        private Label label1;
        private Label label2;
        private Button btnDangKy;
        private CheckBox checkBox1;
        private TextBox txtMatKhau;
        private TextBox txtDangNhap;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
    }
}