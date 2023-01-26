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
    public partial class Form1 : Form
    {
        public string name = null;
        private string user;
        private string password;
        private bool admin;

        public Form1()
        {
            InitializeComponent();
        }
        // For polymorphism - Change list of NormalUsers to Users
        List<User> account = new List<User>();

        private void AddAccount(string name, string user, string pass, bool admin)
        {
            //Creates a new instance of the object, called user
            User u;
            if (admin== true)
            {
                u = new AdminUser();
            }
            else
            {
                u = new NormalUser();
            }
            u.Realname = name;
            u.Username = user;
            u.passwordHash = pass;
            account.Add(u);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            name = Register.Global.name;
            user = Register.Global.user;
            password = Register.Global.password;
            admin = Register.Global.admin;
            AddAccount(name, user, password, admin);


        }

        private User findAccount(string un)
        {
            for (int i = 0; i < account.Count; i++)
            {
                if (account[i].Username == un.ToLower())
                {
                    return account[i];
                }
            }
            return null;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            User user = findAccount(txbxuser.Text);
         

            if (user == null)
            {
                MessageBox.Show("User account not found, please try again.");
                return;
            }
             if (user.CheckPassword(txbxpassword.Text))
            {
                MessageBox.Show("Access Granted");
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register  reg = new Register();
            reg.Show();
        }
    }
}
