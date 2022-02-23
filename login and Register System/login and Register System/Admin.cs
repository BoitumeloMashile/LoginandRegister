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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSTD.tbl_students' table. You can move, or remove it, as needed.
            this.tbl_studentsTableAdapter.Fill(this.dataSetSTD.tbl_students);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Request bub = new Admin_Request();
            bub.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = true;
            
            string search_btn = "Select * from Students where Name like'%" + textBox1.Text + "%'";
            OleDbDataAdapter adap = new OleDbDataAdapter(search_btn, con);
            DataSet dstudents = new DataSet();
            con.Open();
            adap.Fill(dstudents);
            dataGridView.DataSource = dstudents.Tables[0];
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin_Login bub = new Admin_Login();
            bub.Show();
            Visible = false;
        }
    }
}
