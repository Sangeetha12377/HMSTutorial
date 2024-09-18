using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox1.Text;

            if (username == "hms" && password == "pass")
            {
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
                
                //MessageBox.Show("you have entered right username and password");
            }
            else
            {
                 MessageBox.Show("wrong user id or password");
                
            }
        
        }

        
        
        
    }
}
