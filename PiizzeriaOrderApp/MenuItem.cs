using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiizzeriaOrderApp
{
    public class MenuItem
    {
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public string ItemType { get; set; }
        public string FullInfo { get { return $"{ ItemName } { ItemPrice } zł"; } }

        public static List<MenuItem> GetMenuItemsByType(string Type)
        {
            DataAccess db = new DataAccess();
            if(Type != "Add") return db.GetMenu(Type);
            else
            {
                List<MenuItem> PizzaAdds = db.GetMenu("PizzaAdd");
                List<MenuItem> MDAdds = db.GetMenu("MDAdd");

                foreach(MenuItem Item in PizzaAdds)
                {
                    MDAdds.Add(Item);
                }

                return MDAdds;
            }
        }
    }
}
