using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_pointofsale
{
    public partial class FORM_LOGIN : Form
    {
        public FORM_LOGIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BUTTON_MIN_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;

            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void BUTTON_LOGIN_Click(object sender, EventArgs e)
        {
            FORM_MAIN main = new FORM_MAIN();
            main.Show();
            this.Hide();
        }
    }
}
