using ProjectLecture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLecture.Repository
{
    public class DataSingleton
    {
        private static WatchoverEntities1 db = null;

        public static WatchoverEntities1 getInstance()
        {
            if (db == null)
            {
                db = new WatchoverEntities1();
            }
            return db;
        }
    }
}