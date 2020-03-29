using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_pointofsale
{
    public partial class Main_usercontrol : UserControl
    {
        public Main_usercontrol()
        {
            InitializeComponent();
        }

        private void Main_usercontrol_Load(object sender, EventArgs e)
        {

        }

        private void BUTTON_POS_Click(object sender, EventArgs e)
        {
            POS_usercontrol pOS_Usercontrol = new POS_usercontrol();
            _handle_screen(pOS_Usercontrol);
        }
        
        private void Button_Report_Click(object sender, EventArgs e)
        {
            Report_usercontrol report_Usercontrol = new Report_usercontrol();
            _handle_screen(report_Usercontrol);
        }

        private void Button_PdtInfo_Click(object sender, EventArgs e)
        {
            ProductDetails_usercontrol productDetails_Usercontrol = new ProductDetails_usercontrol();
            _handle_screen(productDetails_Usercontrol);
        }

        private void _handle_screen(Control control)
        {
            if(FORM_MAIN._Instance.panelContainer.Controls.ContainsKey("Main_usercontrol"))
            {
                FORM_MAIN._Instance.panelContainer.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
                control.Focus();
                FORM_MAIN._Instance.btn_back.Visible = true;
            }
        }

        
    }
}
