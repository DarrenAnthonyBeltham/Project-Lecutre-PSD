using ProjectLecture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLecture.Factory
{
    public class NewsFactory
    {
        public static News create(int articleid, int userid, String title, String content, String source, DateTime timestamp)
        {
            News news = new News()
            {
                ArticleID = articleid,
                UserID = userid,
                Title = title,
                Content = content,
                Source = source,
                Timestamp = timestamp
            };
            return news;
        }
    }
}