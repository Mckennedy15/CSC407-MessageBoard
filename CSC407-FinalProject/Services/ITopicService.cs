using CSC407_FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSC407_FinalProject.Services
{
    public interface ITopicService
    {
        List<Topic> GetTopic();

        Topic GetTopicById(int id);

        void SaveTopic(Topic topic);

        void DeleteTopic(int id);
    }
}