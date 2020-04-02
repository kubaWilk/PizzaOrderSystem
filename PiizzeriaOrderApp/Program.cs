using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            User UserInfo = new User();
            UserInfo.UserName = "None";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginWindow(ref UserInfo));
            if (UserInfo.UserName == "None") Application.Exit();
                else Application.Run(new OrderWindow(UserInfo));

            Application.Exit();
        }
    }
}
