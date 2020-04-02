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
    public partial class OrderHistory : Form
    {
        User CurrentUser;
        List<UserOrder> OrderHistoryList;
        public OrderHistory(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            OrderHistoryList = CurrentUser.GetOrderHistory();

            OrderHistoryListBox.DataSource = OrderHistoryList;
            OrderHistoryListBox.DisplayMember = "FullInfo";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderHistoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MenuItem> OrderList = OrderHistoryList[OrderHistoryListBox.SelectedIndex].ParseUserOrder();
            SelectedOrderListBox.DataSource = OrderList;
            SelectedOrderListBox.DisplayMember = "FullInfo";
        }
    }
}
