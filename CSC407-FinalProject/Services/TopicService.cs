using CSC407_FinalProject.Data;
using CSC407_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSC407_FinalProject.Services
{
    public class TopicService : ITopicService
    {
        private MessageBoardDbContext context;

        public TopicService()
        {
            this.context = new MessageBoardDbContext();
        }

        public List<Topic> GetTopic()
        {
                return this.context.Topics.ToList();
        }

        public Topic GetTopicById(int id)
        {
            return this.context.Topics.Where(x => x.TopicId == id).SingleOrDefault();
        }

        public void SaveTopic(Models.Topic topic)
        {
            this.context.Topics.Add(topic);
            this.context.SaveChanges();
        }

        public void DeleteTopic(int id)
        {
            var topic = this.context.Topics.Where(x => x.TopicId == id).SingleOrDefault();
            this.context.Topics.Remove(topic);
            this.context.SaveChanges();
        }
    }
}

 
      