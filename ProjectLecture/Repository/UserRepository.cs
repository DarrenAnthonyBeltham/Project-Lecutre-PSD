using ProjectLecture.Factory;
using ProjectLecture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLecture.Repository
{
    public class UserRepository
    {
        private static WatchoverEntities1 db = DataSingleton.getInstance();

        public void createUser(int id, String username, String email, String password)
        {
            User user = UserFactory.create(id, username, email, password);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public List<User> showUsers()
        {
            return (from x in db.Users select x).ToList();
        }
    }
}