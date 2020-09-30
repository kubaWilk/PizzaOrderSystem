using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaOrderLib;

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
            //A very basic input checking
            string[] EmailCheck = EmailTextBox.Text.Split('@');

            if (UserNameTextBox.Text == "" || UserNameTextBox.Text.Contains(" ")) MessageBox.Show("Proszę podać prawidłową nazwę użytkownika!");
            else if (PasswordTextBox.Text == "") MessageBox.Show("Proszę podać hasło!");
            else if (EmailTextBox.Text == "" || EmailTextBox.Text.Contains(" ") || !EmailCheck[EmailCheck.Length - 1].Contains(".")) MessageBox.Show("Proszę podać prawidłowy E - Mail!");
            else if (FirstNameTextBox.Text == "") MessageBox.Show("Proszę podać imię!");
            else if (LastNameTextBox.Text == "") MessageBox.Show("Proszę podać nazwisko!");
            else if (StreetTextBox.Text == "") MessageBox.Show("Proszę podać ulicę!");
            else if (CityTextBox.Text == "") MessageBox.Show("Proszę podać miasto!");
            else if (PostCodeTextBox.Text == "") MessageBox.Show("Proszę podać kod pocztowy!");
            else
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
}
