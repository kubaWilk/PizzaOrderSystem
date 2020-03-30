using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;

namespace PiizzeriaOrderApp
{
    public class DataAccess
    {
        public List<User> LoginUser(User user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MainDB")))
            {
                try
                {
                    var output = connection.Query<User>("dbo.spUsers_Login @UserName, @Password", new { UserName = user.UserName , Password = user.Password }).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong in logging in a user: {ex.Message}");
                    return null;
                }
            }
        }
        public List<User> GetUserByEMail(string EMail)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MainDB")))
            {
                try
                {
                    var output = connection.Query<User>("dbo.spUsers_DoesUserExistByEMail @UserEMail", new { UserEMail = EMail }).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong in getting user info from a database: {ex.Message}");
                    return null;
                }
            }
        }
        public List<MenuItem> GetMenu(string Type)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MainDB")))
            {
                try
                {
                    var output = connection.Query<MenuItem>("dbo.spMenu_GetMenuItemsByType @RequestedType", new { RequestedType = Type }).ToList();
                    return output;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong in getting menu items from a database: {ex.Message}");
                    return null;
                }
            }
        }
        public bool RegisterUser(ref string Status, User UserToRegister)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MainDB")))
            {
                try
                {
                    var output = connection.Query<User>("spUsers_DoesUserExistByUserName @UserName", new { UserName = UserToRegister.UserName }).ToList();
                    User throwMeAnExceptionSenpaiPlz = output[0]; //okay, it's too late to rebuild that function so im just gonna make it throw an exception and change it later.
                    Status = "UserName";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"There is no user with such username in a database: {ex.Message}"); 
                    Status = "Success";
                }

                try
                {
                    if (Status != "UserName")
                    {
                        var output = connection.Query<User>("spUsers_DoesUserExistByEMail @UserEMail", new { UserEMail = UserToRegister.EMail }).ToList();
                        User throwMeAnExceptionSenpaiPlz = output[0]; //okay, it's too late to rebuild that function so im just gonna make it throw an exception and change it later.
                        Status = "EMail"; 
                       

                        return false;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"There is no user with such username & email in a database: {ex.Message}");
                    connection.Execute("dbo.spUsers_InsertANewUser" +
                        " @UserName, @Password, @UserEmail, @FirstName, @LastName, @Street, @City, @PostCode", 
                        new
                        {
                            UserName = UserToRegister.UserName,
                            Password = UserToRegister.Password,
                            UserEmail = UserToRegister.EMail,
                            FirstName = UserToRegister.FirstName,
                            LastName = UserToRegister.LastName,
                            Street = UserToRegister.Street,
                            City = UserToRegister.City,
                            PostCode = UserToRegister.PostCode
                        });
                    Status = "Success";
                    return true;
                }
            }
        }
    }
}
