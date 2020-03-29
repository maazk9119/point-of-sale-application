using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace POS_pointofsale
{
    public partial class add_pdt : Form
    {
        private byte[] Imagedata;
        public static int count;
        public add_pdt()
        {
            InitializeComponent();
            count = 0;

        }

        private void add_pdt_Load(object sender, EventArgs e)
        {
            AddToCombobox();
        }

        private void AddToCombobox()
        {
            List<Products> pp = new List<Products>();
            pp = Products.All_Products();
            foreach(Products obj in pp)
            {
                comboBox1.Items.Add(obj.name);
            }
        }
        
        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                string product = comboBox1.Text;
                string PT_name = textBox_pdtname.Text;
                int PT_price = int.Parse(textBox_pdtprice.Text);
                int PT_quantity = int.Parse(textBox_pdtquantity.Text);
                int p_id = Products.retrive_ID(product);
                int pt_id = Products.RetrivePtypeID(PT_name);
                bool var = check();
                if (var)
                {
                    if (p_id != -1 && pt_id == 0)
                    {
                        bool check = Products.AddProductType(PT_name, PT_quantity, PT_price, Imagedata, p_id);
                        if (check)
                        {
                            count++;
                            MessageBox.Show("Inserted");
                            
                        }
                        else
                        {
                            MessageBox.Show("sorry insert issue");
                        }
                    }
                    else
                    {
                        MessageBox.Show("this name of product is already avaiable", "Alert");
                    }
                }
                else
                {
                    MessageBox.Show("Sorry fill all the requried option", "Alert");
                }
            }
            catch
            {
                MessageBox.Show("Sorry please fill the required option!", "Alert");
            }

        }

        private void BUTTON_UPLOAD_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                Imagedata = new Byte[fileStream.Length];
                fileStream.Read(Imagedata, 0, Imagedata.Length);
                fileStream.Close();

                MemoryStream memoryStream = new MemoryStream(Imagedata);
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
        }

        private void button_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool check()
        {
            if (comboBox1.Text == "" || textBox_pdtname.Text == "" || textBox_pdtprice.Text == "" || textBox_pdtquantity.Text == "" || pictureBox1 == null)
                return false;
            else
                return true;
        }



    }
}
