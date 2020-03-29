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
    public partial class ProductDetails_usercontrol : UserControl
    {
        public ProductDetails_usercontrol()
        {
            InitializeComponent();
            ViewListOnScreen();
        }

        private void ViewListOnScreen()
        {
            CreateTabPages();
            AddProductToTabPages();
        }
        private void CreateTabPages()
        {
            List<Products> products = new List<Products>();
            products = Products.All_Products();
            foreach (Products obj in products)
            {
                tabControl1.TabPages.Add(obj.name);
            }
        }
        
        private void AddProductToTabPages()
        {
            foreach (TabPage tp in tabControl1.TabPages)
            {
                tp.Controls.Clear();
                tp.BackColor = Color.White;

                Label l1 = new Label();
                l1.Text = "IMAGES  ";
                l1.AutoSize = true;
                l1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l1.ForeColor = Color.Black;

                Label l2 = new Label();
                l2.Text = "NAME                                   ";
                l2.AutoSize = true;
                l2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l2.ForeColor = Color.Black;

                Label l3 = new Label();
                l3.Text = "PRICE";
                l3.AutoSize = true;
                l3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l3.ForeColor = Color.Black;

                Label l4 = new Label();
                l4.Text = "QTY                                                      ";
                l4.AutoSize = true;
                l4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l4.ForeColor = Color.Black;

                List<Products> pp = new List<Products>();
                pp.Clear();

                string pdtname = tp.Text;
                int id = Products.retrive_ID(pdtname);
                pp = Products.Product_Details(id);

                FlowLayoutPanel fp = new FlowLayoutPanel();
                fp.AutoScroll = true;
                fp.Dock = DockStyle.Fill;
                fp.Controls.Add(l1);
                fp.Controls.Add(l2);
                fp.Controls.Add(l3);
                fp.Controls.Add(l4);

                foreach (Products obj in pp)
                {

                    PictureBox pc = new PictureBox();
                    pc.Size = new System.Drawing.Size(80, 80);
                    pc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    Image img = obj.imgae;
                    pc.Image = img;

                    TextBox tb = new TextBox();
                    tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tb.Size = new System.Drawing.Size(200, 4);
                    tb.Text = obj.name;
        
                    tb.Enabled = false;

                    TextBox tb1 = new TextBox();
                    tb1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tb1.Size = new System.Drawing.Size(50, 29);
                    tb1.Text = obj.price.ToString();
                    tb1.Enabled = false;


                    TextBox tb2 = new TextBox();
                    tb2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tb2.Size = new System.Drawing.Size(50, 29);
                    tb2.Text = obj.quantity.ToString();
                    tb2.Enabled = false;

                    Button btn = new Button();
                    btn.BackColor = Color.FromArgb(57, 44, 113);
                    btn.ForeColor = Color.White;
                    btn.Size = new Size(108,46);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.Text = "Update";
                    btn.Enabled = true;
                    string n = tb.Text;
                    btn.Tag = obj;
                    btn.Click +=  new EventHandler(UpdateOnClick);

                    Button btn1 = new Button();
                    btn1.BackColor = Color.FromArgb(255, 0, 0);
                    btn1.ForeColor = Color.White;
                    btn1.Size = new Size(50, 46);
                    btn1.FlatAppearance.BorderSize = 0;
                    btn1.FlatStyle = FlatStyle.Flat;
                    btn1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn1.Text = "X";
                    btn1.Enabled = true;
                    btn1.Tag = obj;
                    btn1.Click += new EventHandler(DeleteOnClick);


                    fp.BackColor = Color.White;
                    fp.BorderStyle = BorderStyle.None;
                    fp.Controls.Add(pc);
                    fp.Controls.Add(tb);
                    fp.Controls.Add(tb1);
                    fp.Controls.Add(tb2);
                    fp.Controls.Add(btn);
                    fp.Controls.Add(btn1);
                    
                }
               
                tp.Controls.Add(fp);

            }
        }

        private void BUTTON_ADD_Click(object sender, EventArgs e)
        {
            add_pdt pp = new add_pdt();
            pp.Show();
           
        }

        private void UpdateOnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Products pp = (Products)b.Tag;
            Updatedpt obj = new Updatedpt(pp.name,pp.price,pp.quantity,pp.imgae);
            obj.Show();
            
        }


        private void DeleteOnClick(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you want to delete this item?", "DELETE", buttons);
            if (result == DialogResult.Yes)
            {
                Button b = (Button)sender;
                Products pp = (Products)b.Tag;

                bool check = Products.DeleteProductType(pp.name);
                if (check)
                {
                    AddProductToTabPages();
                }
                else
                    MessageBox.Show("not found");

            }
        }
        
     
    }
}
