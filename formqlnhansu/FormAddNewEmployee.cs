using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// bước 1: khai báo thư viện
using Microsoft.Data.SqlClient;


namespace formqlnhansu
{
    public partial class FormAddNewEmployee : Form
    {
        // bước 2: khai báo đối tượng kết nối CSDL
        SqlConnection conn = new SqlConnection(@"Server = ADMIN\SQLEXPRESS; Database = HRM_DB; Integrated Security = True; TrustServerCertificate = True;");

        public FormAddNewEmployee()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // bước 3: Mở kết nối tới CSDL
            conn.Open();

            // Bước 4: Thực thi câu lệnh
            string gender = rdoMale.Checked ? "Nam" : "Nữ";
            string commandText = "INSERT INTO Employees VALUES('"+txtEmployeeID.Text+"',N'"+txtFullname.Text+"',N'"+gender+"','"+txtBirtday.Text+"',N'"+txtHome.Text+"','"+cboDepartment.SelectedValue+"',N'"+cboPosition.Text+"',N'"+cboLevel.Text+"','"+txtEmail.Text+"','"+txtPhone.Text+"')";
            SqlCommand cmd = new SqlCommand(commandText, conn);
            cmd.ExecuteNonQuery();
            

            // Bước 5: Đóng kết nối
            conn.Close();


            FormAddNewEmployee_Load(sender, e);


            //dgvEmployees.AllowUserToAddRows = true;
            //DataGridViewRow row = (DataGridViewRow)dgvEmployees.Rows[0].Clone();   

            //row.Cells[0].Value = txtEmployeeID.Text;
            //row.Cells[1].Value = txtFullname.Text;
            //row.Cells[2].Value = rdoMale.Checked ? "Nam" : "Nữ";
            //row.Cells[3].Value = txtBirtday.Text;
            //row.Cells[4].Value = txtHome.Text;          
            //row.Cells[5].Value = cboDepartment.Text;
            //row.Cells[6].Value = cboPosition.Text;          
            //row.Cells[7].Value = cboLevel.Text;
            //row.Cells[8].Value = txtEmail.Text;
            //row.Cells[9].Value = txtPhone.Text;

            //dgvEmployees.Rows.Add(row);
            //dgvEmployees.AllowUserToAddRows = true;

        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = dgvEmployees.CurrentRow.Cells[0].Value.ToString();
            txtFullname.Text = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
            rdoMale.Checked = dgvEmployees.CurrentRow.Cells[2].Value.ToString() == "Nam" ? true : false;
            txtBirtday.Text = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
            txtHome.Text = dgvEmployees.CurrentRow.Cells[4].Value.ToString();           
            cboDepartment.Text = dgvEmployees.CurrentRow.Cells[5].Value.ToString();
            cboPosition.Text = dgvEmployees.CurrentRow.Cells[6].Value.ToString();            
            cboLevel.Text = dgvEmployees.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = dgvEmployees.CurrentRow.Cells[8].Value.ToString();
            txtPhone.Text = dgvEmployees.CurrentRow.Cells[9].Value.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // bước 3: Mở kết nối tới CSDL
            conn.Open();

            // Bước 4: Thực thi câu lệnh
            string gender = rdoMale.Checked ? "Nam" : "Nữ";
            string commandText = "UPDATE Employees SET Fullname = N'" + txtFullname.Text + "', Gender = N'" + gender + "', Birthday = '" + txtBirtday.Text + "', Address = N'" + txtHome.Text + "', DepartmenID = '" + cboDepartment.SelectedValue + "', Position = N'" + cboPosition.Text + "', Degree = N'" + cboLevel.Text + "', Email = '" + txtEmail.Text + "', Phone = '" + txtPhone.Text + "' WHERE EmployeesID = '" + txtEmployeeID.Text + "'";
            SqlCommand cmd = new SqlCommand(commandText, conn);
            cmd.ExecuteNonQuery();


            // Bước 5: Đóng kết nối
            conn.Close();


            FormAddNewEmployee_Load(sender, e);


            //DataGridViewRow row = (DataGridViewRow)dgvEmployees.Rows[0].Clone();
            //dgvEmployees.CurrentRow.Cells[0].Value = txtEmployeeID.Text;
            //dgvEmployees.CurrentRow.Cells[1].Value = txtFullname.Text;
            //dgvEmployees.CurrentRow.Cells[2].Value = rdoMale.Checked ? "Nam" : "Nữ";
            //dgvEmployees.CurrentRow.Cells[3].Value = txtBirtday.Text;
            //dgvEmployees.CurrentRow.Cells[4].Value = txtHome.Text;           
            //dgvEmployees.CurrentRow.Cells[5].Value = cboDepartment.Text;
            //dgvEmployees.CurrentRow.Cells[6].Value = cboPosition.Text;
            //dgvEmployees.CurrentRow.Cells[7].Value = cboLevel.Text;
            //dgvEmployees.CurrentRow.Cells[8].Value = txtEmail.Text;
            //dgvEmployees.CurrentRow.Cells[9].Value = txtPhone.Text;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa nhan vien dang chon khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //dgvEmployees.Rows.Remove(dgvEmployees.CurrentRow);
                // bước 3: Mở kết nối tới CSDL
                conn.Open();

                // Bước 4: Thực thi câu lệnh
                string gender = rdoMale.Checked ? "Nam" : "Nữ";
                string commandText = "DELETE FROM Employees WHERE EmployeesID = '" + txtEmployeeID.Text + "'";
                SqlCommand cmd = new SqlCommand(commandText, conn);
                cmd.ExecuteNonQuery();


                // Bước 5: Đóng kết nối
                conn.Close();


                FormAddNewEmployee_Load(sender, e);
            }
        
    }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployees.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(toolStripTextBox1.Text))
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddNewEmployee_Load(object sender, EventArgs e)
        {
            // bước 3: Mở kết nối tới CSDL
            conn.Open();

            // Bước 4: Thực thi câu lệnh
            string commandText = "SELECT * FROM Employees";
            SqlCommand cmd = new SqlCommand(commandText,conn);          
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Employees"); 
            da.Fill(dt); // điền dữ liệu vào table
            dgvEmployees.DataSource = dt;


            // lấy về danh sách phòng ban
            string commandText1 = "SELECT * FROM Departments";
            SqlCommand cmd1 = new SqlCommand(commandText1, conn);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable("Employees");
            da1.Fill(dt1); // điền dữ liệu vào table
            cboDepartment.DataSource = dt1;
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentID";


            // Bước 5: Đóng kết nối
            conn.Close();
            da.Dispose();
        }

        private void cboDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // bước 3: Mở kết nối tới CSDL
            conn.Open();

            //// Bước 4: Thực thi câu lệnh
            //string commandText = "SELECT * FROM Employees WHERE DepartmenID = '"+cboDepartment.SelectedValue+"'";//SelectedValue lấy ra ID (SelectedText laays ra ten)
            //SqlCommand cmd = new SqlCommand(commandText, conn);
            //cmd.CommandType = CommandType.Text;
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable("Employees");
            //da.Fill(dt); // điền dữ liệu vào table
            //dgvEmployees.DataSource = dt;

            // bước 4 thực thi câu lệnh bằng thủ tục
            string commandText = "GetEmployeesByDepartID";//SelectedValue lấy ra ID (SelectedText laays ra ten)
            SqlCommand cmd = new SqlCommand(commandText, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@DepartID",cboDepartment.SelectedValue);
            cmd.Parameters.Add(p);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Employees");
            da.Fill(dt); // điền dữ liệu vào table
            dgvEmployees.DataSource = dt;

            // Bước 5: Đóng kết nối
            conn.Close();
            da.Dispose();
        }
    }
}
