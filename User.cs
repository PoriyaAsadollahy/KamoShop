using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class User
    {
        public string Name { get; }
        public string Password { get; }
        public List<Product> ShoppingCart { get; set; }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
            ShoppingCart = new List<Product>();
        }
    }

    static class UserList
    {
        public static List<User> users = new List<User>();
    }
}
