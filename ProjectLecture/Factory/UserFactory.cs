using ProjectLecture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLecture.Factory
{
    public class UserFactory
    {
        public static User create(int userID, String username, String email, String password)
        {
            User user = new User()
            {
                UserID = userID,
                Username = username,
                Email = email,
                Password = password
            };
            return user;
        }
    }
}