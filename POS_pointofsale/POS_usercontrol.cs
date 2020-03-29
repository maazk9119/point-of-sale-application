using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace POS_pointofsale
{
    public partial class POS_usercontrol : UserControl
    {
        DataTable dataTable = new DataTable();
        List<Orders> makeOrder;
        public POS_usercontrol()
        {
            InitializeComponent();
            updates();
        }

        public void updates()
        {
            CreateTabPages();
            AddProductToTabpages();
            makeOrder = new List<Orders>();
           
          
        }

        private void POS_usercontrol_Load(object sender, EventArgs e)
        {
            
            dataTable.Columns.Add("FOOD NAME", typeof(string));
            dataTable.Columns.Add("PRICE", typeof(string));
            dataTable.Columns.Add("QUANTITY", typeof(string));
            tabControl2.TabPages.Add("Delete");
            dataGridView1.DataSource = dataTable;
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

        //left side foods shown by this function
        public void AddProductToTabpages()
        {
            List<Products> pp = new List<Products>();
            foreach (TabPage tp in tabControl1.TabPages)
            {
                tp.BackColor = Color.White;
                pp.Clear();
                string pdtname = tp.Text;
                int id = Products.retrive_ID(pdtname);
                pp = Products.Product_Details(id);
                
                FlowLayoutPanel fp = new FlowLayoutPanel();
                fp.AutoScroll = true;
                fp.Dock = DockStyle.Fill;
                foreach (Products obj in pp)
                {
                    Button btn = new Button();
                    btn.Size = new Size(100,100);
                    btn.Tag = obj;
                    btn.Click += new EventHandler(AddPdtToOrder);
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackgroundImage = obj.imgae;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    fp.Controls.Add(btn);
                }
                tp.Controls.Add(fp);
            }
        }

        //when the button click this function will call
        private void AddPdtToOrder(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Products pp = (Products)b.Tag;
            string PT_name = pp.name;
            int PT_price = pp.price;
            int PT_quantity = 1;
            makeOrder =  Orders.AddNewOrderDetails(PT_name, PT_price, PT_quantity);
            AddToGrid();
            AddDeleteButtons();
        }


        //make the delete button with respect to the order list 
        private void AddDeleteButtons()
        {
            foreach (TabPage tp in tabControl2.TabPages)
            {
                tp.Controls.Clear();
                tp.BorderStyle = BorderStyle.None;
                tp.BackColor = Color.White;
                FlowLayoutPanel fp = new FlowLayoutPanel();
                fp.AutoScroll = true;
                fp.Dock = DockStyle.Fill;
                fp.BackColor = Color.White;
                fp.BorderStyle = BorderStyle.None;

                foreach (Orders order in makeOrder)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.FromArgb(57, 44, 113);
                    btn.ForeColor = Color.White;
                    btn.Padding = new Padding(0);
                    btn.Size = new Size(20, 20);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.Text = "E";
                    btn.Enabled = true;
                    btn.Tag = order;
                    btn.Click += new EventHandler(DeleteRow);
                    fp.Controls.Add(btn);
                }
                tp.Controls.Add(fp);
            }
        }
        
        //remove the row-data from the grid after clicking the delete button(run time generated)
        private void DeleteRow(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Orders oo = (Orders)b.Tag;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == oo.PT_NAME)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    tabControl2.Controls.Remove(b);
                    b.Dispose();
                    break;
                }
            }
            int Index = 0;
            foreach (Orders ob in makeOrder)
            {
                if (ob.PT_NAME == oo.PT_NAME)
                {
                    break;
                }
                Index++;
            }
            makeOrder.RemoveAt(Index);
            AddToGrid();

        }

        //show the make-order list into grid
        private void AddToGrid()
        {
            dataTable.Rows.Clear();
            foreach (Orders order in makeOrder)
            {
                dataTable.Rows.Add(order.PT_NAME, order.PT_Price, order.PT_Qty);
            }
            dataGridView1.DataSource = dataTable;
        }
    }
}
