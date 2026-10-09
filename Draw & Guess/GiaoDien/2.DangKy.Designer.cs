namespace Draw___Guess
{
    partial class Form2
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            button2 = new Button();
            txtTaiKhoan = new TextBox();
            txtEmail_SDT = new TextBox();
            txtCheckMK = new TextBox();
            txtMatKhau = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(58, 157);
            label2.Name = "label2";
            label2.Size = new Size(151, 24);
            label2.TabIndex = 16;
            label2.Text = "Email hoặc SĐT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(58, 90);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 15;
            label1.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(58, 295);
            label3.Name = "label3";
            label3.Size = new Size(178, 24);
            label3.TabIndex = 20;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(58, 227);
            label4.Name = "label4";
            label4.Size = new Size(102, 24);
            label4.TabIndex = 19;
            label4.Text = "Mật khẩu";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(154, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(521, 38);
            textBox1.TabIndex = 21;
            textBox1.Text = "ĐĂNG KÝ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(625, 358);
            button4.Name = "button4";
            button4.Size = new Size(147, 46);
            button4.TabIndex = 23;
            button4.Text = "Đăng ký";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(444, 358);
            button2.Name = "button2";
            button2.Size = new Size(147, 46);
            button2.TabIndex = 22;
            button2.Text = "Đăng nhập";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Segoe UI", 12F);
            txtTaiKhoan.Location = new Point(269, 87);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(406, 34);
            txtTaiKhoan.TabIndex = 24;
            // 
            // txtEmail_SDT
            // 
            txtEmail_SDT.Font = new Font("Segoe UI", 12F);
            txtEmail_SDT.Location = new Point(269, 154);
            txtEmail_SDT.Name = "txtEmail_SDT";
            txtEmail_SDT.Size = new Size(406, 34);
            txtEmail_SDT.TabIndex = 25;
            // 
            // txtCheckMK
            // 
            txtCheckMK.Font = new Font("Segoe UI", 12F);
            txtCheckMK.Location = new Point(269, 285);
            txtCheckMK.Name = "txtCheckMK";
            txtCheckMK.Size = new Size(406, 34);
            txtCheckMK.TabIndex = 27;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(269, 218);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(406, 34);
            txtMatKhau.TabIndex = 26;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCheckMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail_SDT);
            Controls.Add(txtTaiKhoan);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.WindowText;
            Name = "Form2";
            Text = "Đăng ký";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button4;
        private Button button2;
        private TextBox txtTaiKhoan;
        private TextBox txtEmail_SDT;
        private TextBox txtCheckMK;
        private TextBox txtMatKhau;
    }
}