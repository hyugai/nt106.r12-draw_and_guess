namespace client
{
    partial class HomeForm
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
            btnDangXuat = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTenDangNhap = new Label();
            lblEmail = new Label();
            lblThoiGianLogin = new Label();
            lblXinChao = new Label();
            SuspendLayout();
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.Location = new Point(523, 384);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(152, 64);
            btnDangXuat.TabIndex = 10;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Bold);
            label3.Location = new Point(36, 303);
            label3.Name = "label3";
            label3.Size = new Size(296, 32);
            label3.TabIndex = 9;
            label3.Text = "Lần đăng nhập gần nhất:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Bold);
            label2.Location = new Point(36, 220);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 8;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Bold);
            label1.Location = new Point(35, 142);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 7;
            label1.Text = "Tên đăng nhập:";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 12F);
            lblTenDangNhap.Location = new Point(242, 142);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(0, 28);
            lblTenDangNhap.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(144, 220);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 28);
            lblEmail.TabIndex = 12;
            // 
            // lblThoiGianLogin
            // 
            lblThoiGianLogin.AutoSize = true;
            lblThoiGianLogin.Font = new Font("Segoe UI", 12F);
            lblThoiGianLogin.Location = new Point(338, 303);
            lblThoiGianLogin.Name = "lblThoiGianLogin";
            lblThoiGianLogin.Size = new Size(0, 28);
            lblThoiGianLogin.TabIndex = 13;
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXinChao.ForeColor = Color.FromArgb(0, 192, 0);
            lblXinChao.Location = new Point(36, 60);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(161, 38);
            lblXinChao.TabIndex = 14;
            lblXinChao.Text = "XIN CHÀO ";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 500);
            Controls.Add(lblXinChao);
            Controls.Add(lblThoiGianLogin);
            Controls.Add(lblEmail);
            Controls.Add(lblTenDangNhap);
            Controls.Add(btnDangXuat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomeForm";
            Text = "Trang chủ";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblTenDangNhap;
        private Label lblEmail;
        private Label lblThoiGianLogin;
        private Label lblXinChao;
        private Button btnDangXuat;
    }
}