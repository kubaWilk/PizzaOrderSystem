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
        public OrderWindow()
        {
            InitializeComponent();
            List<MenuItem> MainDishMenu = new List<MenuItem>();
            List<MenuItem> PizzaMenu = new List<MenuItem>();
            List<MenuItem> SoupsMenu = new List<MenuItem>();
            List<MenuItem> AdditivesMenu = new List<MenuItem>();
            List<MenuItem> DrinksMenu = new List<MenuItem>();

            //Setting up some sample data before adding SQL connection to the app
            MainDishMenu.Add(new MenuItem("MainDish", 20, "MainDish1"));
            PizzaMenu.Add(new MenuItem("Pizza", 20, "Pizza1"));
            SoupsMenu.Add(new MenuItem("Soup", 20, "Soup1"));
            AdditivesMenu.Add(new MenuItem("Add", 20, "Additive1"));
            DrinksMenu.Add(new MenuItem("Drink", 20, "Drink1"));

            MenuItemsListBox.DisplayMember = "FullInfo";
            MenuItemsListBox.DataSource = MainDishMenu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
        }
    }
}
