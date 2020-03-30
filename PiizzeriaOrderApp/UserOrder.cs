using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiizzeriaOrderApp
{
    public class UserOrder
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string OrderItems { get; set; }
        public string OrderComments { get; set; }

        public bool PlaceOrder(List<MenuItem> OrderList, User user, string Comments)
        {
            DataAccess Db = new DataAccess();
            //this.ID = Db.GetNewOrderID() + 1;
            this.UserID = user.ID;
            this.OrderComments = Comments;

            for (int index = 0; index < OrderList.Count; index++)
            {
                this.OrderItems += $"{OrderList[index].ItemName} ;";
            }

            if (Db.PutOrderInDB(this)) return true;
            else return false;
        }
    }
}  