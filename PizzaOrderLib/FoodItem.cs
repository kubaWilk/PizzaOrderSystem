using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderLib
{
    public class FoodItem
    {
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public string ItemType { get; set; }
        public string FullInfo { get { return $"{ ItemName } { ItemPrice } zł"; } }
    }
}
