using ProjectLecture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLecture.Factory
{
    public class PostFactory
    {
        public static Post create(int postid, int userid, String title, String content, DateTime timestamp)
        {
            Post post = new Post()
            {
                PostID = postid,
                UserID = userid,
                Title = title,
                Content = content,
                Timestamp = timestamp
            };
            return post;
        }
    }
}