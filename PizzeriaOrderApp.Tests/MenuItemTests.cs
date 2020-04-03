using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PiizzeriaOrderApp;

namespace PizzeriaOrderApp.Tests
{
    public class MenuItemTests
    {
        [Theory]
        [InlineData("Pizza")]
        [InlineData("MainDish")]
        public void GetMenuItemsByType_ItemNamesShouldEqual(string Type) 
        {
            DataAccess db = new DataAccess();
            List<MenuItem> Expected = db.GetMenu(Type); //we're assuming DataAccess works perfectly.
            List<MenuItem> Actual = MenuItem.GetMenuItemsByType(Type);

            for (int index = 0; index < Expected.Count; index++)
            {
                Assert.Equal(Expected[index].ItemName, Actual[index].ItemName);
            }
            
        }
        [Fact]
        public void GetMenuItemsByType_AddShouldReturnAllAdds()
        {
            DataAccess db = new DataAccess();
            List<MenuItem> Expected = db.GetMenu("MDAdd");
            List<MenuItem> PizzaAdds = db.GetMenu("PizzaAdd");
            
            foreach (MenuItem item in PizzaAdds) Expected.Add(item);

            List<MenuItem> Actual = MenuItem.GetMenuItemsByType("Add");

            for (int index = 0; index < Expected.Count; index++)
            {
                Assert.Equal(Expected[index].ItemName, Actual[index].ItemName);
            }
        }
    }
}
