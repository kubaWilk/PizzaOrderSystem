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
        private List<MenuItem> UserOrder = new List<MenuItem>();
        private User CurrentUser;
        private int SummedOrderPrice = 0;
        
        public OrderWindow(User UserInfo)
        {
            InitializeComponent();
            CurrentUser = UserInfo;
            MenuItemsListBox.DisplayMember = "FullInfo";
            OrderItemsListBox.DisplayMember = "FullInfo";
            SummedOrderPriceLabel.Text = "SUMA: 0zł";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            //I think it still needs to have a functionality of adding items inside a list. To be done later.
            MenuItem tempMenuItem = MenuItemsListBox.SelectedItem as MenuItem;

            if (tempMenuItem.ItemType == "PizzaAdd")
            {
                    int count = 1;
                    while (count < 5)
                    {
                        try
                        {
                            MenuItem AddCheckItem = OrderItemsListBox.Items[OrderItemsListBox.Items.Count - count] as MenuItem;
                        if (AddCheckItem.ItemType != "Pizza" && AddCheckItem.ItemType != "PizzaAdd") { MessageBox.Show("Nie można wybrać tego dodatku do wybranego dania."); break; }
                            if (AddCheckItem.ItemType == "Pizza")
                            {
                                OrderItemsListBox.Items.Add(tempMenuItem);
                                UserOrder.Add(tempMenuItem);
                                SummedOrderPrice += tempMenuItem.ItemPrice;
                                SummedOrderPriceLabel.Text = $"SUMA: {SummedOrderPrice}zł";
                                break;
                            }
                            else if (AddCheckItem.ItemName == tempMenuItem.ItemName) // && AddCheckItem.ItemType != "Pizza"
                            {
                                MessageBox.Show("Nie można dodać tego samego dodatku dwa razy!");
                                break;
                            }
                            else count++;
                        }
                        catch(ArgumentOutOfRangeException ex)
                        {
                            MessageBox.Show("Na liście brakuje dania, do którego można wybrać dodatek.");
                            Console.WriteLine("Catched an expression : {0}", ex.Message);
                            break;
                        }
                    }
            }
            else if (tempMenuItem.ItemType == "MDAdd")
            {
                try
                {
                    int count = 1;
                    while (count < 5)
                    {
                        try
                        {
                            MenuItem AddCheckItem = OrderItemsListBox.Items[OrderItemsListBox.Items.Count - count] as MenuItem;
                            if (AddCheckItem.ItemType != "MainDish" && AddCheckItem.ItemType != "MDAdd") { MessageBox.Show("Nie można wybrać tego dodatku do wybranego dania."); break; }
                            if (AddCheckItem.ItemType == "MainDish")
                            {
                                OrderItemsListBox.Items.Add(tempMenuItem);
                                UserOrder.Add(tempMenuItem);
                                SummedOrderPrice += tempMenuItem.ItemPrice;
                                SummedOrderPriceLabel.Text = $"SUMA: {SummedOrderPrice}zł";
                                break;
                            }
                            else if (AddCheckItem.ItemName == tempMenuItem.ItemName && AddCheckItem.ItemType != "MainDish")
                            {
                                MessageBox.Show("Nie można dodać tego samego dodatku dwa razy!");
                                break;
                            }
                            else count++;

                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            MessageBox.Show("Na liście brakuje dania, do którego można wybrać dodatek.");
                            Console.WriteLine("Catched an expression : {0}", ex);
                            break;
                        }
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Musisz wybrać danie, do którego chcesz dodatek!");
                    Console.WriteLine("Catched an expression : {0}", ex.Message);
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

            MenuItemsListBox.DataSource = MenuItem.GetMenuItemsByType("MainDish");
            MenuItemsListBox.DisplayMember = "FullInfo";
        }

        private void PizzaButton_Click(object sender, EventArgs e)
        {
            MenuItemsListBox.DataSource = MenuItem.GetMenuItemsByType("Pizza");
            MenuItemsListBox.DisplayMember = "FullInfo";
        }

        private void SoupsButton_Click(object sender, EventArgs e)
        {
            MenuItemsListBox.DataSource = MenuItem.GetMenuItemsByType("Soup");
            MenuItemsListBox.DisplayMember = "FullInfo";
        }

        private void MDAddsButton_Click(object sender, EventArgs e)
        {
            MenuItemsListBox.DataSource = MenuItem.GetMenuItemsByType("Add");
            MenuItemsListBox.DisplayMember = "FullInfo";
        }

        private void DrinksButton_Click(object sender, EventArgs e)
        {
            MenuItemsListBox.DataSource = MenuItem.GetMenuItemsByType("Drink");
            MenuItemsListBox.DisplayMember = "FullInfo";
        }

        private void DeleteFromOrderButton_Click(object sender, EventArgs e)
        {
            MenuItem tempMenuItem = OrderItemsListBox.SelectedItem as MenuItem;

            if (tempMenuItem.ItemType == "Pizza" || tempMenuItem.ItemType == "MainDish")
            {
                for (int count = 0; count < 5; count++)
                {
                    try
                    {
                        MenuItem TempUserOrderRef = UserOrder[OrderItemsListBox.SelectedIndex + 1];
                        if (TempUserOrderRef.ItemType != "PizzaAdd" && TempUserOrderRef.ItemType != "MDAdd")
                        {
                            if (tempMenuItem.ItemType == "Pizza" || tempMenuItem.ItemType == "MainDish")
                            {
                                UserOrder.RemoveAt(OrderItemsListBox.SelectedIndex);
                                OrderItemsListBox.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
                                SummedOrderPrice -= tempMenuItem.ItemPrice;
                                SummedOrderPriceLabel.Text = $"SUMA: {SummedOrderPrice}zł";
                            }
                                break;
                        }
                        SummedOrderPrice -= TempUserOrderRef.ItemPrice;
                        OrderItemsListBox.Items.RemoveAt(OrderItemsListBox.SelectedIndex + 1);
                        UserOrder.RemoveAt(OrderItemsListBox.SelectedIndex + 1);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        if(tempMenuItem.ItemType == "Pizza" || tempMenuItem.ItemType == "MainDish")
                        {
                            UserOrder.RemoveAt(OrderItemsListBox.SelectedIndex);
                            OrderItemsListBox.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
                            SummedOrderPrice -= tempMenuItem.ItemPrice;
                            SummedOrderPriceLabel.Text = $"SUMA: {SummedOrderPrice}zł";
                            break;
                        }
                        Console.WriteLine("Catched an expression : {0}", ex.Message);

                    }
                }
            }
            else
            {
                UserOrder.RemoveAt(OrderItemsListBox.SelectedIndex);
                OrderItemsListBox.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
                SummedOrderPrice -= tempMenuItem.ItemPrice;
            }
            SummedOrderPriceLabel.Text = $"SUMA: {SummedOrderPrice}zł";
        }

        private void SummedOrderPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void PlaceAnOrderButton_Click(object sender, EventArgs e)
        {
            UserOrder order = new UserOrder();
            //order.PlaceOrder(UserOrder, CurrentUser, OrderCommentsTextBox.Text);

            if (order.PlaceOrder(UserOrder, CurrentUser, OrderCommentsTextBox.Text))
            {
                EmailSender OrderEmail = new EmailSender();
                OrderEmail.SendAnEmail(CurrentUser, order);
                MessageBox.Show("Zamówienie złożono pomyślnie.");
            }
            else
            {
                Console.WriteLine("Złożenie zamówienia nie powiodło się.");
            }
}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void historiaZamówieńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderHistory OrderHistoryWindow = new OrderHistory(CurrentUser);
            OrderHistoryWindow.Show();
        }
    }
}
