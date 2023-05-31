using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formqlnhansu
{
    public partial class FormMain : Form
    {
        public bool isExit = true;

        public event EventHandler logout;

        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        #region event

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout(this, new EventArgs());
        }


        #endregion

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            bool isExists = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmAddimployee")
                {
                    f.Activate();
                    isExists = true;
                    break;

                }
            }
            if (!isExists)
            {
                FormAddNewEmployee frm = new FormAddNewEmployee();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }


        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
                FormAddNewEmployee frm = new FormAddNewEmployee();

                frm.Show();
            


        }
    }
 }
 
