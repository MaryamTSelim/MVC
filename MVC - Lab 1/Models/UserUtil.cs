using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC___Lab_1.Models
{
    static public class UserUtil
    {
        public static List<User> myUsers = new List<User> { new User { Username =  "Maryam" , Password = "1"} };
        public static void Push(User newUser)
        {
            myUsers.Add(newUser);
        }
        public static void Push(string newUserName , string newUserPassword)
        {
            myUsers.Add(new User { Username = newUserName , Password = newUserPassword});
        }
    }
}