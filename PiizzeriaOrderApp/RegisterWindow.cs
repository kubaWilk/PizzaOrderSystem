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
    public partial class RegisterWindow : Form
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            User UserToRegister = new User();

            UserToRegister.UserName = UserNameTextBox.Text;
            UserToRegister.Password = PasswordTextBox.Text;
            UserToRegister.EMail = EmailTextBox.Text;
            UserToRegister.FirstName = FirstNameTextBox.Text;
            UserToRegister.LastName = LastNameTextBox.Text;
            UserToRegister.Street = StreetTextBox.Text;
            UserToRegister.City = CityTextBox.Text;
            UserToRegister.PostCode = PostCodeTextBox.Text;

            string Status = "";
            if (UserToRegister.RegisterAUser(ref Status))
            {
                MessageBox.Show("Rejestracja powiodła się.");
                Close();
            }
            else
            {
                if (Status == "UserName")
                    MessageBox.Show("Wybrana nazwa użytkownika jest już zajęta.");
                else if (Status == "EMail")
                    MessageBox.Show("Użytkownik o takim adresie E - Mail już istnieje.");
            }
        }
    }
}
