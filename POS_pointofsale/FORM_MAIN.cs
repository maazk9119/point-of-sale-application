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
    public partial class FORM_MAIN : Form
    {
        private static FORM_MAIN _instance;
        public static FORM_MAIN _Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new FORM_MAIN();
                }
                return _instance;
            }
        }

        public Panel panelContainer
        {
            get { return PANEL_CONTROL; }
            set { PANEL_CONTROL = value;}
        }

        public Button btn_back
        {
            get { return BUTTON_BACK; }
            set { BUTTON_BACK = value;}
        }
        public FORM_MAIN()
        {
            InitializeComponent();
        }

        private void FORM_MAIN_Load(object sender, EventArgs e)
        {
            BUTTON_BACK.Visible = false;
            _instance = this;
            Main_usercontrol main_Usercontrol = new Main_usercontrol();
            main_Usercontrol.Dock = DockStyle.Fill;
            PANEL_CONTROL.Controls.Add(main_Usercontrol);
        }
        
        //exit and minimize the application functionality
        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BUTTON_MIN_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;

            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void BUTTON_BACK_Click(object sender, EventArgs e)
        {
            PANEL_CONTROL.Controls["Main_usercontrol"].BringToFront();
            BUTTON_BACK.Visible = false;
        }
        
        private void PANEL_CONTROL_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
