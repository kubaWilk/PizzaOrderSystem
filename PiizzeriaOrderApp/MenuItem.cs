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

        public MenuItem(string NewItemType = "NullType", int NewItemPrice = 0, string NewItemName = "NullName")
        {
            ItemName = NewItemName;
            ItemPrice = NewItemPrice;
            ItemType = NewItemType;
        }
    }
}
