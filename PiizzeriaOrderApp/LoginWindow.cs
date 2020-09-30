using System;
using System.Windows.Forms;
using PizzaOrderLib;

namespace PiizzeriaOrderApp
{
    public partial class LoginWindow : Form
    {

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterWindow RWindow = new RegisterWindow();
            RWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(UserLoggingIn.UserLogIn(UserNameTextBox.Text, PasswordTextBox.Text))
            {
                /*
                    * 10 - no login
                    * 11 - no password
                    * 1 - logged in successfully
                    * 0 - bad input
                */
                case 10: 
                    {
                        MessageBox.Show("Proszę podać login.");
                        break;
                    }
                case 11:
                    {
                        MessageBox.Show("Proszę podać hasło.");
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("Zalogowano pomyślnie!");
                        OrderWindow orderWindow = new OrderWindow();
                        orderWindow.Show();
                        Close();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Proszę spróbować jeszcze raz.");
                        break;
                    }
            }
        }
    }
}
