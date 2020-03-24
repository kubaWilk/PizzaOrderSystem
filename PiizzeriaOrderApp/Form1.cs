using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiizzeriaOrderApp
{
    public partial class OrderWindow : Form
    {
        private List<MenuItem> WholeMenu;
        private List<MenuItem> UserOrder = new List<MenuItem>();
        private int SummedOrderPrice = 0;
        private void GetWholeMenu()
        {
            WholeMenu = new List<MenuItem>();
            WholeMenu.Add(new MenuItem("MainDish", 20, "MainDish1"));
            WholeMenu.Add(new MenuItem("Pizza", 20, "Pizza1"));
            WholeMenu.Add(new MenuItem("Soup", 20, "Soup1"));
            WholeMenu.Add(new MenuItem("MDAdd", 20, "MainDishAdditive1"));
            WholeMenu.Add(new MenuItem("PizzaAdd", 20, "Additive1"));
            WholeMenu.Add(new MenuItem("PizzaAdd", 20, "Additive2"));
            WholeMenu.Add(new MenuItem("Drink", 20, "Drink1"));
        }

        private List<MenuItem> GetTypeMenuList(string MenuItemType)
        {
            List<MenuItem> ItemTypeList = new List<MenuItem>();

            if(MenuItemType == "Add")
            {
                for (int index = 0; index < WholeMenu.Count; index++)
                {
                    if (WholeMenu[index].ItemType == "PizzaAdd") ItemTypeList.Add(WholeMenu[index]);
                }
                for (int index = 0; index < WholeMenu.Count; index++)
                {
                    if (WholeMenu[index].ItemType == "MDAdd") ItemTypeList.Add(WholeMenu[index]);
                }
            }

            for (int index = 0; index < WholeMenu.Count; index++)
            {
                if (WholeMenu[index].ItemType == MenuItemType) ItemTypeList.Add(WholeMenu[index]);
            }

            return ItemTypeList;
        }

        public OrderWindow()
        {
            InitializeComponent();
            GetWholeMenu();

            MenuItemsListBox.DataSource = GetTypeMenuList("MainDish");
            MenuItemsListBox.DisplayMember = "FullInfo";
            OrderItemsListBox.DisplayMember = "FullInfo";
            SummedOrderPriceLabel.Text = "SUMA: 0zł";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            MenuItem tempMenuItem = MenuItemsListBox.SelectedItem as MenuItem;

            if (tempMenuItem.ItemType == "PizzaAdd")
            {
                try
                {
                    int count = 1;
                    while (count < 5)
                    {
                        MenuItem AddCheckItem = OrderItemsListBox.Items[OrderItemsListBox.Items.Count - count] as MenuItem;
                        if (AddCheckItem.ItemType == "Pizza")
                        {
                            OrderItemsListBox.Items.Add(tempMenuItem);
                            UserOrder.Add(tempMenuItem);
                            SummedOrderPrice += tempMenuItem.ItemPrice;
                            SummedOrderPriceLabel.Text = $"SUMA: {SummedOrderPrice}zł";
                            break;
                        }
                        if (AddCheckItem.ItemName == tempMenuItem.ItemName)
                        {
                            MessageBox.Show("Nie można dodać tego samego dodatku dwa razy!");
                            break;
                        }
                        count++;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Musisz wybrać danie, do którego chcesz dodatek!");
                }
            }
            else
            {
                UserOrder.Add(tempMenuItem);
                OrderItemsListBox.Items.Add(tempMenuItem);
                SummedOrderPrice += tempMenuItem.ItemPrice;
                SummedOrderPriceLabel.Text = $"SUMA: {SummedOrderPrice}zł";
            }

        }

        private void MainDishButton_Click(object sender, EventArgs e)
        {
            MenuItemsListBox.DataSource = GetTypeMenuList("MainDish");
            MenuItemsListBox.DisplayMember = "FullInfo";
        }

        private void PizzaButton_Click(object sender, EventArgs e)
        {
            MenuItemsListBox.DataSource = GetTypeMenuList("Pizza");
            MenuItemsListBox.DisplayMember = "FullInfo";
        }

        private void SoupsButton_Click(object sender, EventArgs e)
        {
            MenuItemsListBox.DataSource = GetTypeMenuList("Soup");
            MenuItemsListBox.DisplayMember = "FullInfo";
        }

        private void MDAddsButton_Click(object sender, EventArgs e)
        {
            MenuItemsListBox.DataSource = GetTypeMenuList("Add");
            MenuItemsListBox.DisplayMember = "FullInfo";
        }

        private void DrinksButton_Click(object sender, EventArgs e)
        {
            MenuItemsListBox.DataSource = GetTypeMenuList("Drink");
            MenuItemsListBox.DisplayMember = "FullInfo";
        }

        private void DeleteFromOrderButton_Click(object sender, EventArgs e)
        {
            UserOrder.RemoveAt(OrderItemsListBox.SelectedIndex);
            OrderItemsListBox.Items.RemoveAt(OrderItemsListBox.SelectedIndex);

            MenuItem tempMenuItem = MenuItemsListBox.SelectedItem as MenuItem;
            SummedOrderPrice -= tempMenuItem.ItemPrice;

            SummedOrderPriceLabel.Text = $"SUMA: {SummedOrderPrice}zł";
        }

        private void SummedOrderPriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
