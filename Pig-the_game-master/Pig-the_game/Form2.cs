using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pig_the_game
{
    public partial class Form2 : Form
    {
        class form2var
        {
            public static string Player1 = "";
            public static string Player2 = "";
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.playernam1 = txtboxp1name.Text;
            frm1.playernam2 = txtboxp2name.Text;
            frm1.ShowDialog();
            this.Close();
        }
    }
}
