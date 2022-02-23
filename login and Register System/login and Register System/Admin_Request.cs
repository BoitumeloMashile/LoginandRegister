using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace login_and_Register_System
{
    public partial class Admin_Request : Form
    {
        public Admin_Request()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Admin_Request_Load(object sender, EventArgs e)
        {
           


        }

        private void learning_Click(object sender, EventArgs e)
        {

        }

        private void rsn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stdNo.Text == "" && answers.Text == "" )
            {
                MessageBox.Show("Some fields are empty", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                con.Open();
                string request = "INSERT INTO tbl_Answers VALUES ('" + stdNo.Text + "','" + answers.Text + "')";
                cmd = new OleDbCommand(request, con);
                cmd.ExecuteNonQuery();
                con.Close();

                stdNo.Text = "";
                answers.Text = "";
                


                MessageBox.Show("Sent Successfully", "Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Login bub = new Admin_Login();
            bub.Show();
            Visible = false;
        }

        private void stdNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tblRequestsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tblAnswersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
