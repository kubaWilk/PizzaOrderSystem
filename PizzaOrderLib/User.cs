using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderLib
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        public bool RegisterAUser(ref string Status)
        {
            DataAccess Db = new DataAccess();
            if (Db.RegisterUser(ref Status, this)) return true;
            else return false;
        }

        public List<UserOrder> GetOrderHistory()
        {
            DataAccess Db = new DataAccess();
            return Db.GetOrderHistory(this.ID);
        }
    }
}
