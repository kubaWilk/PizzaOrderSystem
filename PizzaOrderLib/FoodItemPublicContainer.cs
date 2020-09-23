using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderLib
{
    public class FoodItemPublicContainer
    {
        public static readonly List<FoodItem> WholeMenu = GetWholeMenuFromDB();

        public static readonly List<FoodItem> MainDish = GetMenuItemFromDb("MainDish");
        public static readonly List<FoodItem> Add = GetMenuItemFromDb("Add");
        public static readonly List<FoodItem> Pizza = GetMenuItemFromDb("Pizza");
        public static readonly List<FoodItem> Soup = GetMenuItemFromDb("Soup");
        public static readonly List<FoodItem> Drink = GetMenuItemFromDb("Drink");

        public static List<FoodItem> getMainDish()
        {
            return MainDish;
        }

        public static List<FoodItem> getAdd()
        {
            return Add;
        }

        public static List<FoodItem> getPizza()
        {
            return Pizza;
        }

        public static List<FoodItem> getSoup()
        {
            return Soup;
        }

        public static List<FoodItem> getDrink()
        {
            return Drink;
        }

        public static List<FoodItem> getWholeMenu()
        {
            return WholeMenu;
        }

        public static List<FoodItem> GetMenuItemFromDb(string Type)
        {
            DataAccess db = new DataAccess();
            if (Type != "Add") return db.GetMenu(Type);
            else
            {
                List<FoodItem> PizzaAdds = db.GetMenu("PizzaAdd");
                List<FoodItem> MDAdds = db.GetMenu("MDAdd");

                foreach (FoodItem Item in PizzaAdds)
                {
                    MDAdds.Add(Item);
                }

                return MDAdds;
            }
        }

        public static List<FoodItem> GetWholeMenuFromDB()
        {
            List<FoodItem> WholeMenu = new List<FoodItem>();
            foreach (FoodItem item in MainDish)
            {
                WholeMenu.Add(item);
            }

            foreach (FoodItem item in Add)
            {
                WholeMenu.Add(item);
            }

            foreach (FoodItem item in Pizza)
            {
                WholeMenu.Add(item);
            }

            foreach (FoodItem item in Soup)
            {
                WholeMenu.Add(item);
            }

            foreach (FoodItem item in Drink)
            {
                WholeMenu.Add(item);
            }

            return WholeMenu;
        }
    }
}

