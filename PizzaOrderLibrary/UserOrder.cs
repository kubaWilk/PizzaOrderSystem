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
        public string FullInfo 
        {
            get
            {
                return $"Zamówienie nr {ID}: ";
            } 
        }

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

        public List<MenuItem> ParseUserOrder()
        {
            List<MenuItem> WholeMenu = MenuItem.GetWholeMenu();
            List<MenuItem> SelectedOrder = new List<MenuItem>();

            List<string> OrderItemsTable = new List<string>();

            foreach (string split in OrderItems.Split(';'))
            {
                if (split != "") OrderItemsTable.Add(split.Trim());
            }

            foreach(string search in OrderItemsTable)
            {
                SelectedOrder.Add(WholeMenu.Find(x => x.ItemName.Contains(search)));
            }

            return SelectedOrder;
        }
    }
}  