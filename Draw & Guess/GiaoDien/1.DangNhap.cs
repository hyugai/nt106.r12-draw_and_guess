namespace Draw___Guess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnDangNhap(object sender, EventArgs e)
        {
            LoiTen.Text = "";
            LoiMatKhau.Text = "";
            LoiChung.Text = "";

            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;
            bool Empty = false;
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                LoiTen.Text = "Chua nhap ten dang nhap";
                Empty = true;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                LoiMatKhau.Text = "Chua nhap mat khau";
                Empty = true;
            }
            if (Empty) return;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
