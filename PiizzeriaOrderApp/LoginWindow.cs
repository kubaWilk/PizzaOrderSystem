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
    public partial class LoginWindow : Form
    {
        private User UserRef, tempUser;
        public LoginWindow(ref User UserInfo)
        {
            UserRef = UserInfo;
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterWindow RWindow = new RegisterWindow();
            RWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "") MessageBox.Show("Proszę podać login!");
            else if (PasswordTextBox.Text == "") MessageBox.Show("Proszę podać hasło!");
            else
            {
                UserRef.UserName = UserNameTextBox.Text;
                UserRef.Password = PasswordTextBox.Text;
                tempUser = UserRef.GetUser();

                if (tempUser != null)
                {
                    MessageBox.Show("Udało się zalogować!");
                    UserRef.ID = tempUser.ID;
                    UserRef.UserName = tempUser.UserName;
                    UserRef.Password = tempUser.Password;
                    UserRef.EMail = tempUser.EMail;
                    UserRef.FirstName = tempUser.FirstName;
                    UserRef.LastName = tempUser.LastName;
                    UserRef.Street = tempUser.Street;
                    UserRef.City = tempUser.City;
                    UserRef.PostCode = tempUser.PostCode;
                    Close();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowe dane logowania");
                }
            }
        }
    }
}
