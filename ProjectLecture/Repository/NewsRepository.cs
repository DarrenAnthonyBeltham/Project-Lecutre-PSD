using ProjectLecture.Factory;
using ProjectLecture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLecture.Repository
{
    public class NewsRepository
    {
        public WatchoverEntities1 db = DataSingleton.getInstance();

        public List<News> showNews()
        {
            return (from x in db.News select x).ToList();
        } 

        public void insertNews(int articleid, int userid, string title, string content, string source, DateTime timestamp)
        {
            News news = NewsFactory.create(articleid, userid, title, content, source, timestamp);
            db.News.Add(news);
            db.SaveChanges();
        }

        public void deleteNews(int articleid)
        {
            News news = db.News.Find(articleid);
            if(news != null)
            {
                db.News.Remove(news);
                db.SaveChanges();
            }
        }

        public void updateNews(int articleid, int userid, string title, string content, string source, DateTime timestamp)
        {
            News news = db.News.Find(articleid);
            if(news != null)
            {
                news.ArticleID = articleid;
                news.UserID = userid;
                news.Title = title;
                news.Content = content;
                news.Source = source;
                news.Timestamp = timestamp;

                db.SaveChanges();
            }
            else
            {
                throw new Exception("News not found!");
            }
        }

        public int generateId()
        {
            Random random = new Random();
            int randomNumber = random.Next(101);
            return randomNumber;
        }
    }
}