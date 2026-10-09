namespace Draw___Guess
{
    partial class Form1
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
            txtThongBao = new TextBox();
            btnQuenMatKhau = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            checkBox1 = new CheckBox();
            txtMatKhau = new TextBox();
            txtDangNhap = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtThongBao
            // 
            txtThongBao.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtThongBao.Location = new Point(114, 38);
            txtThongBao.Name = "txtThongBao";
            txtThongBao.ReadOnly = true;
            txtThongBao.Size = new Size(464, 38);
            txtThongBao.TabIndex = 0;
            txtThongBao.Text = "ĐĂNG NHẬP";
            txtThongBao.TextAlign = HorizontalAlignment.Center;
            txtThongBao.Visible = false;
            // 
            // btnQuenMatKhau
            // 
            btnQuenMatKhau.Location = new Point(532, 238);
            btnQuenMatKhau.Name = "btnQuenMatKhau";
            btnQuenMatKhau.Size = new Size(131, 51);
            btnQuenMatKhau.TabIndex = 3;
            btnQuenMatKhau.Text = "Quên mật khẩu?";
            btnQuenMatKhau.UseVisualStyleBackColor = true;
            btnQuenMatKhau.Click += btnQuenMatKhau_Click;
            // 
            // button2
            // 
            button2.Location = new Point(371, 348);
            button2.Name = "button2";
            button2.Size = new Size(131, 51);
            button2.TabIndex = 4;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(31, 148);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 7;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(31, 249);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu";
            // 
            // button3
            // 
            button3.Location = new Point(532, 348);
            button3.Name = "button3";
            button3.Size = new Size(131, 51);
            button3.TabIndex = 10;
            button3.Text = "Đăng ký";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 311);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(140, 307);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Ghi nhớ tôi";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(140, 246);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(361, 34);
            txtMatKhau.TabIndex = 13;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtDangNhap
            // 
            txtDangNhap.Font = new Font("Segoe UI", 12F);
            txtDangNhap.Location = new Point(140, 144);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(361, 34);
            txtDangNhap.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 15;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(140, 181);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(142, 284);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(692, 479);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnQuenMatKhau);
            Controls.Add(txtThongBao);
            ForeColor = SystemColors.WindowText;
            Name = "Form1";
            Text = "Đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtThongBao;
        private Button btnQuenMatKhau;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
        private Label label3;
        private CheckBox checkBox1;
        private TextBox txtMatKhau;
        private TextBox txtDangNhap;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
