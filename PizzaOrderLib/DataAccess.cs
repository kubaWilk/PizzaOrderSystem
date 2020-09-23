using System;
using System.Collections.Generic;
using Dapper;
using System.Data;

namespace PizzaOrderLib
{
    public class DataAccess
    {
        private List<User> generateSampleUser()
        {
            List<User> output = new List<User>();
            output.Add(new User
            {
                ID = 0,
                UserName = "test",
                Password = "test",
                EMail = "test",
                FirstName = "Sample",
                LastName = "User",
                Street = "Sample Street",
                PostCode = "test"
            });
            return output;
        }

        private List<FoodItem> generateSampleMenu()
        {
            List<FoodItem> output = new List<FoodItem>();

            output.Add(new FoodItem 
            {
                ItemName = "SamplePizza",
                ItemPrice = 2137,
                ItemType = "Pizza"
            });

            output.Add(new FoodItem
            {
                ItemName = "SampleMainDish",
                ItemPrice = 2137,
                ItemType = "MainDish"
            });

            output.Add(new FoodItem
            {
                ItemName = "SampleSoup",
                ItemPrice = 2137,
                ItemType = "Soup"
            });

            output.Add(new FoodItem
            {
                ItemName = "SampleAdditive",
                ItemPrice = 2137,
                ItemType = "PizzaAdd"
            });

            output.Add(new FoodItem
            {
                ItemName = "SampleAdditive",
                ItemPrice = 2137,
                ItemType = "MDAdd"
            });

            output.Add(new FoodItem
            {
                ItemName = "SampleDrink",
                ItemPrice = 2137,
                ItemType = "Drink"
            });

            return output;
        }
        public List<User> LoginUser(User user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MainDB")))
            {
                try
                {
                    //var output = connection.Query<User>("dbo.spUsers_Login @UserName, @Password", new { UserName = user.UserName , Password = user.Password }).ToList();
                    //return output;

                    return generateSampleUser();
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
                    //var output = connection.Query<User>("dbo.spUsers_DoesUserExistByEMail @UserEMail", new { UserEMail = EMail }).ToList();
                    //return output;

                    return generateSampleUser();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong in getting user info from a database: {ex.Message}");
                    return null;
                }
            }
        }
        public List<FoodItem> GetMenu(string Type)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MainDB")))
            {
                try
                {
                    //var output = connection.Query<MenuItem>("dbo.spMenu_GetMenuItemsByType @RequestedType", new { RequestedType = Type }).ToList();
                    //return output;

                    return generateSampleMenu();
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
                    //var output = connection.Query<User>("spUsers_DoesUserExistByUserName @UserName", new { UserName = UserToRegister.UserName }).ToList();
                    //User throwMeAnException = output[0];  //after a bit of thinking I've decided it's not that bad idea
                    //Status = "UserName";

                    return true;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"There is no user with such username in a database: {ex.Message}"); 
                    Status = "Success";
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Something went wrong: {0}.", ex.Message);
                    return false;
                }

                try
                {
                    if (Status != "UserName")
                    {
                        //var output = connection.Query<User>("spUsers_DoesUserExistByEMail @UserEMail", new { UserEMail = UserToRegister.EMail }).ToList();
                        //User throwMeAnException = output[0]; 
                        //Status = "EMail"; 


                        //return false;

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
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
                catch(Exception ex)
                {
                    Console.WriteLine("Something went wrong: {0}", ex.Message);
                    return false;
                }
            }
        }

        public bool PutOrderInDB(UserOrder order)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MainDB")))
            {
                try
                {
                    //connection.Execute("dbo.spOrders_InsertANewOrder @UserID, @OrderItems, @OrderComments", order);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong in getting menu items from a database: {ex.Message}");
                    return false;
                }
            }
        }

        public List<UserOrder> GetOrderHistory(int UserID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MainDB")))
            {
                try
                {
                    //var output = connection.Query<UserOrder>("dbo.spOrders_GetOrderHistory @UserID", new { UserID = UserID}).ToList();
                    List<UserOrder> output = new List<UserOrder>();
                    output.Add(new UserOrder
                    {
                        ID = 0,
                        UserID = 0,
                        OrderItems = "",
                        OrderComments = "",
                    });
                    return output;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong in getting Order History from a database: {ex.Message}");
                    return null;
                }
            }
        }
        
    }
}
