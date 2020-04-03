using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiizzeriaOrderApp;
using Xunit;

namespace PizzeriaOrderApp.Tests
{
    public class UserOrderTests
    {
        [Fact]
        public void ParseOrder_ShouldReturnProperList()
        {
            UserOrder SomeUserOrder = new UserOrder { OrderItems = "Margheritta ;Podwójny Ser ; Cola ;" };
            List<MenuItem> Expected = new List<MenuItem>
            {
                new MenuItem
                {
                    ItemName = "Margheritta",
                    ItemPrice = 20,
                    ItemType = "Pizza"
                },
                new MenuItem
                {
                    ItemName = "Podwójny Ser",
                    ItemPrice = 2,
                    ItemType = "PizzaAdd"
                },
                new MenuItem
                {
                    ItemName = "Cola",
                    ItemPrice = 5,
                    ItemType = "Drink"
                }
            };

            List<MenuItem> Actual = SomeUserOrder.ParseUserOrder();

            for (int index = 0; index < Expected.Count; index++)
            {
                Assert.Equal(Expected[index].ItemName, Actual[index].ItemName);
            }
        }
    }
}
