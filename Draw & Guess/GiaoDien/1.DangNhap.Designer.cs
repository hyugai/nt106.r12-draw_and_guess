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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            label3 = new Label();
            checkBox1 = new CheckBox();
            txtMatKhau = new TextBox();
            txtDangNhap = new TextBox();
            SuspendLayout();
            // 
            // txtThongBao
            // 
            txtThongBao.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtThongBao.Location = new Point(128, 34);
            txtThongBao.Name = "txtThongBao";
            txtThongBao.ReadOnly = true;
            txtThongBao.Size = new Size(521, 38);
            txtThongBao.TabIndex = 0;
            txtThongBao.Text = "ĐĂNG NHẬP";
            txtThongBao.TextAlign = HorizontalAlignment.Center;
            txtThongBao.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(598, 214);
            button1.Name = "button1";
            button1.Size = new Size(147, 46);
            button1.TabIndex = 3;
            button1.Text = "Quên mật khẩu?";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(417, 313);
            button2.Name = "button2";
            button2.Size = new Size(147, 46);
            button2.TabIndex = 4;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(35, 133);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 7;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(35, 224);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu";
            // 
            // button4
            // 
            button4.Location = new Point(598, 313);
            button4.Name = "button4";
            button4.Size = new Size(147, 46);
            button4.TabIndex = 10;
            button4.Text = "Đăng ký";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 280);
            label3.Name = "label3";
            label3.Size = new Size(0, 18);
            label3.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(158, 276);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 22);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Ghi nhớ tôi";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(158, 221);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(406, 34);
            txtMatKhau.TabIndex = 13;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtDangNhap
            // 
            txtDangNhap.Font = new Font("Segoe UI", 12F);
            txtDangNhap.Location = new Point(158, 130);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(406, 34);
            txtDangNhap.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(778, 431);
            Controls.Add(txtDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button4;
        private Label label3;
        private CheckBox checkBox1;
        private TextBox txtMatKhau;
        private TextBox txtDangNhap;
    }
}
