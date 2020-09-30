using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderLib
{
    public class UserLoggingIn
    {
        public static User currentUser;

        public static User UserLogInDB(string login, string password)
        {
            DataAccess Db = new DataAccess();
            List<User> User;
            User = Db.LoginUser(new User { UserName = login, Password = password });

            if (User.Count == 0)
            {
                return null;
            }
            else if (User[0].UserName != login && User[0].Password != password) return null;
            else return User[0];
        }

        public static int UserLogIn(string login, string password) 
        {
            /*
             * 10 - incorrect login
             * 11 - incorrect password
             * 1 - logged in successfully
             * 0 - bad input
             */

            if (login == "") return 10;
            else if (password == "") return 11;
            else
            {
                User tempUser = UserLogInDB(login, password);

                if (tempUser != null)
                {
                    currentUser.ID = tempUser.ID;
                    currentUser.UserName = tempUser.UserName;
                    currentUser.Password = tempUser.Password;
                    currentUser.EMail = tempUser.EMail;
                    currentUser.FirstName = tempUser.FirstName;
                    currentUser.LastName = tempUser.LastName;
                    currentUser.Street = tempUser.Street;
                    currentUser.City = tempUser.City;
                    currentUser.PostCode = tempUser.PostCode;
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
