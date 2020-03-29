using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace POS_pointofsale
{
    public partial class Updatedpt : Form
    {
        private string PT_name;
        private int PT_price;
        private int PT_quantity;
        private Image image;
      
        public Updatedpt(string PT_name,int PT_price, int PT_quantity, Image image)
        {
            InitializeComponent();
            this.PT_name = PT_name;
            this.PT_price = PT_price;
            this.PT_quantity = PT_quantity;
            this.image = image;

            textBox_pdtname.Text = this.PT_name;
            textBox_pdtprice.Text = this.PT_price.ToString();
            textBox_pdtquantity.Text = this.PT_quantity.ToString();
            pictureBox1.Image = this.image;   
            
        }


        private void button_ok_Click(object sender, EventArgs e)
        {
            string name = textBox_pdtname.Text;
            int qty = int.Parse(textBox_pdtquantity.Text);
            int price = int.Parse(textBox_pdtprice.Text);
            Image img = pictureBox1.Image;

            if (this.PT_name != name || this.PT_price != price || this.PT_quantity != qty || this.image != img)
            {
                Byte[] image = ImageToByte(img);
                bool check = Products.UpdateProductType(name, qty, price, image);
                if (check)
                    MessageBox.Show("Updated");
                else
                    MessageBox.Show("something went wrong");
            }
            else
                MessageBox.Show("please make change something for update");
        }

        private void button_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public bool State()
        {
            if (WindowState == FormWindowState.Normal)
                return false;
            else
                return true;
        }
    }
}
