using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public static class Global
        {
            public static string name;
            public static string user;
            public static string password;
            public static bool admin;
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txbxusername.Text;
            string password = txbxpassword.Text;


            Global.name = txbxname.Text;
            Global.user = user.ToLower();
            Global.password = password.ToLower();
            if (ckbxadmin.Checked)
            {
                Global.admin = true;
            }
            else
            {
                Global.admin= false;
            }
            
            this.Hide();
            Form1 back = new Form1();
            back.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
