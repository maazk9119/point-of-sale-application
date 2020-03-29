using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace POS_pointofsale
{
    class Orders
    {
        private string PT_name;
        private int PT_price;
        private int PT_quantity;
        private Image  PT_image;

        public string PT_NAME
        {
            get
            {
                return PT_name;
            }
        }

        public int PT_Price
        {
            get
            {
                return PT_price;
            }
        }

        public int PT_Qty
        {
            get
            {
                return PT_quantity;
            }
        }


        public Orders(string PT_name, int PT_price, int PT_quantity)
        {
            this.PT_name = PT_name;
            this.PT_price = PT_price;
            this.PT_quantity = PT_quantity;
        }



        static List<Orders>  MakeOrder = new List<Orders>();
        public static List<Orders> AddNewOrderDetails(string name, int price, int quantity = 1)
        {
            int count = 0;
            foreach(Orders obj in MakeOrder)
            {
                if(obj.PT_name == name)
                {
                    obj.PT_quantity++;
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                MakeOrder.Add(new Orders(name, price, quantity));
            } 
           return MakeOrder;
        }

        public static bool DeleteOrder()
        {

            return false;
        }
        public static bool AddNewOrders()
        {

            return false;
        }

        public static bool UpdateOrder()
        {

            return false;
        }

        public static bool DeleteOrderDetials()
        {

            return false;
        }
    }
}
