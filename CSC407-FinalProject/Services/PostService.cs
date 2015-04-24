using CSC407_FinalProject.Data;
using CSC407_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSC407_FinalProject.Services
{
    public class PostingService : IPostService
    {
      private MessageBoardDbContext context;

        public PostingService()
        {
            this.context = new MessageBoardDbContext();
        }

        public List<Post> GetPost()
        {
            return this.context.Posts.ToList();
        }

        public Post GetPostById(int id)
        {
            return this.context.Posts.Where(x => x.PostId == id).SingleOrDefault();
        }

        public void SavePost(Models.Post post)
        {
            this.context.Posts.Add(post);
            this.context.SaveChanges();
        }

        public void DeletePost(int id)
        {
            var post = this.context.Posts.Where(x => x.PostId == id).SingleOrDefault();
            this.context.Posts.Remove(post);
            this.context.SaveChanges();
        }
        public List<Post> GetPostsByTopicId(int id)
        {
            return this.context.Posts.Where(x => x.TopicId == id).ToList();
        }
    }
}