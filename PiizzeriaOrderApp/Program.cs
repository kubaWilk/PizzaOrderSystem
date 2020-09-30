using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaOrderLib;

namespace PiizzeriaOrderApp
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserLoggingIn.currentUser = new User { UserName = "null" };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginWindow());
            if (UserLoggingIn.currentUser.UserName == "null") Application.Exit();
            else Application.Run(new OrderWindow());

            Application.Exit();
        }
    }
}
