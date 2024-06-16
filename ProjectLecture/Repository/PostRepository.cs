using ProjectLecture.Factory;
using ProjectLecture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLecture.Repository
{
    public class PostRepository
    {
        public WatchoverEntities1 db = DataSingleton.getInstance();

        public List<Post> showNews()
        {
            return (from x in db.Posts select x).ToList();
        }

        public void insertNews(int postid, int userid, string title, string content, DateTime timestamp)
        {
            Post post = PostFactory.create(postid, userid, title, content, timestamp);
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public void deletePost(int postid)
        {
            Post post = db.Posts.Find(postid);
            if (post != null)
            {
                db.Posts.Remove(post);
                db.SaveChanges();
            }
        }

        public void updatePost(int postid, int userid, string title, string content, DateTime timestamp)
        {
            Post post = db.Posts.Find(postid);
            if (post != null)
            {
                post.PostID = postid;
                post.UserID = userid;
                post.Title = title;
                post.Content = content;
                post.Timestamp = timestamp;

                db.SaveChanges();
            }
            else
            {
                throw new Exception("Post not found!");
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