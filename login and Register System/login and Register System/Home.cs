using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_and_Register_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void std_btn_Click(object sender, EventArgs e)
        {
            Student_Login bub = new Student_Login();
            bub.Show();
            Visible = false;
        }

        private void adn_btn_Click(object sender, EventArgs e)
        {
            Admin_Login bub = new Admin_Login();
            bub.Show();
            Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
