using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Errorexceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Int32.Parse(textBox1.Text);
                //use "Exception" if you don't know which error it might come up.
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter a number! "+ ex.Message);
            }
        }
    }
}
