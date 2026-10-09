using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography; 
using System.Text;                  
using System.Windows.Forms;
namespace Draw___Guess
{
    public partial class Form1 : Form
    {
        private string connectionstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=Dangnhap;Integrated Security=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }
        private string HamBam(string password)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

            string tenDangNhap = txtDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;
            bool Empty = false;
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                label5.Text = "Chưa nhập tên đăng nhập";
                Empty = true;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                label6.Text = "Chưa nhập mật khẩu";
                Empty = true;
            }
            if (Empty) return;

            using (SqlConnection connect = new SqlConnection(connectionstring))
            {
                connect.Open();
                string query = "SELECT MATKHAU FROM Users WHERE TEN = @Ten";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Ten", tenDangNhap);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        bool kiemtra = false;
                        if (reader.Read())
                        {
                            string matkhauSQL = reader["MATKHAU"].ToString();
                            string matkhaubam = HamBam(matKhau);
                            if (string.Equals(matkhauSQL, matkhaubam, StringComparison.OrdinalIgnoreCase))
                            {
                                kiemtra = true;
                            }
                        }
                        if (kiemtra)
                        {
                            MessageBox.Show("Đăng nhập thành công!");
                            this.Hide();
                            Form3 trangchu = new Form3();
                            trangchu.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            label4.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 dangky = new Form2();
            dangky.ShowDialog();
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

