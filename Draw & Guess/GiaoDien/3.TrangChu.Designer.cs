namespace Draw___Guess
{
    partial class Form3
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(22, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 43);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Bold);
            label1.Location = new Point(22, 117);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Bold);
            label2.Location = new Point(22, 191);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Bold);
            label3.Location = new Point(22, 270);
            label3.Name = "label3";
            label3.Size = new Size(296, 32);
            label3.TabIndex = 3;
            label3.Text = "Lần đăng nhập gần nhất:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(569, 339);
            button2.Name = "button2";
            button2.Size = new Size(171, 58);
            button2.TabIndex = 5;
            button2.Text = "Đăng xuất";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            ForeColor = SystemColors.WindowText;
            Name = "Form3";
            Text = "Trang chủ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}