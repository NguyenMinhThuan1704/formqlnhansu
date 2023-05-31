namespace formqlnhansu
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        bool checklogin(string userName , string passWord)
        {
            for (int i = 0 ; i < ListUser.Instance.ListAccountUser.Count; i++)
            {
                if(userName == ListUser.Instance.ListAccountUser[i].UserName &&  passWord == ListUser.Instance.ListAccountUser[i].Password)
                    return true;
            }    
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txbusername.Text;
            string passWord = txbpassword.Text;

            if (checklogin(userName,passWord))
            {
                FormMain f = new FormMain();
                f.Show();
                this.Hide();
                f.Layout += F_Layout;
            }

            else
            {
                MessageBox.Show("Sai Tài khoản hoặc Mật khẩu","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txbusername.Focus();
                return;
            }    
        }

        private void F_Layout(object sender, EventArgs e)
        {
            (sender as FormMain).isExit = false;
            (sender as FormMain).Close();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             if(checkBox1.Checked)
                txbpassword.UseSystemPasswordChar = false;

             if(checkBox1.Checked)
                txbpassword.UseSystemPasswordChar = true;
        }
    }
}