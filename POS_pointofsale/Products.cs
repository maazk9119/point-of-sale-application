using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;

namespace POS_pointofsale
{
    class Products
    {

        private string P_NAME;
        private int Price;
        private int Quantity;
        private Image IMAGE;
        private static string connectionstring = @"Data Source=LAPTOP-6OSHRANK\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";

        public string name
        {
            get
            {
                return P_NAME;
            }
        }

        public Image imgae
        {
            get
            {
                return IMAGE;
            }

        }

        public int price
        {
            get
            {
                return Price;
            }
        }

        public int quantity
        {
            get
            {
                return Quantity;
            }
        }
        
        //this is for products name
        public Products(string p_name)
        {
            this.P_NAME = p_name;
        }

        //this is for the product detials which is in product_type table
        public Products(string Name,int Price,int Quantity, Image image)
        {
            this.P_NAME = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.IMAGE = image;
        }

        public static bool AddProduct()
        {


            return false;
        }

        public static bool DeleteProduct()
        {

            return false;
        }

        //product detials
        public static bool AddProductType(string PT_name, int PT_quantity, int PT_price, Byte[] Image, int P_id)
        {
            string query = "INSERT INTO PRODUCTS_TYPE (PT_NAME,PT_QUANTITY,PT_PRICE,PT_IMAGE,P_ID) VALUES(@NAME,@QUANTITY,@PRICE,@IMAGE,@ID)";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NAME", PT_name);
                cmd.Parameters.AddWithValue("@QUANTITY", PT_quantity);
                cmd.Parameters.AddWithValue("@PRICE", PT_price);
                cmd.Parameters.AddWithValue("@IMAGE", Image);
                cmd.Parameters.AddWithValue("@ID", P_id);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        //product detials
        public static bool UpdateProductType(string PT_name, int PT_quantity, int PT_price, Byte[] image)
        {
            int PT_ID = RetrivePtypeID(PT_name);
            string query = "UPDATE PRODUCTS_TYPE SET PT_NAME = @NAME, PT_QUANTITY = @QTY, PT_PRICE = @PRICE, PT_IMAGE = @IMG WHERE PT_ID = @ID";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NAME",PT_name);
                cmd.Parameters.AddWithValue("@QTY", PT_quantity);
                cmd.Parameters.AddWithValue("@PRICE", PT_price);
                cmd.Parameters.AddWithValue("@IMG", image);
                cmd.Parameters.AddWithValue("@ID", PT_ID);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception)
                {
                   // MessageBox.Show("sorry" + x);
                }

            }

            return false;
        }

        //product detials
        public static bool DeleteProductType(string pdt_name)
        {
            int pt_id = RetrivePtypeID(pdt_name);
            if (pt_id != -1)
            {
                string query = "DELETE FROM PRODUCTS_TYPE WHERE PT_ID = @ID";
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID", pt_id);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                    catch (Exception)
                    {
                        // MessageBox.Show("" + x);
                    }
                }

            }

            return false;
        }

        //all the products 
        public static List<Products> All_Products()
        {
            List<Products> products = new List<Products>();
            string query = "SELECT *FROM PRODUCTS";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand sqlcom = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = sqlcom.ExecuteReader();
                    while (reader.Read())
                    {
                        products.Add(new Products(reader["P_NAME"].ToString()));
                    }
                    connection.Close();
                }

                catch (Exception)
                {
                   
                }
            }
            return products;
        }


        //retrive the product id
        public static int retrive_ID(string pdt_name)
        {
            string query = "SELECT P_ID FROM PRODUCTS WHERE P_NAME = @Pname";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Pname", pdt_name);
                try
                {
                    connection.Open();
                    int p_id = Convert.ToInt32(cmd.ExecuteScalar());
                    connection.Close();
                    return p_id;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        //make a list of product_type against the product id
        public static List<Products> Product_Details(int id)
        {
            List<Products> pp = new List<Products>();
            string query = "SELECT PT_NAME,PT_QUANTITY,PT_PRICE,PT_IMAGE FROM PRODUCTS_TYPE WHERE P_ID = @ID";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id);
                connection.Open();
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string name = reader["PT_NAME"].ToString();
                        int price = int.Parse(reader["PT_PRICE"].ToString());
                        int quantity = int.Parse(reader["PT_QUANTITY"].ToString());
                        var img = reader["PT_IMAGE"];

                        System.Drawing.ImageConverter c = new ImageConverter();
                        Image image = (Image)c.ConvertFrom(img);
                        pp.Add(new Products(name, price, quantity, image));
                    }
                    connection.Close();
                }
                catch (Exception)
                {
                    //MessageBox.Show("error for ??" + ex)
                }
            }
     
            return pp;
        }
        
        //retirve the product type id
        public static int RetrivePtypeID(string pdt_name)
        {
            string query = "SELECT PT_ID FROM PRODUCTS_TYPE WHERE PT_NAME = @NAME";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NAME", pdt_name);
                try
                {
                    connection.Open();
                    int p_id = Convert.ToInt32(cmd.ExecuteScalar());
                    connection.Close();
                    return p_id;
                }
                catch (Exception )
                {
                    //MessageBox.Show("Sorry!\n " + x);
                }
                return 0;
            }
        }


        
    }
}
