using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSC407_FinalProject.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string TopicMessage { get; set; }
        public string TopicName { get; set; }
        public string TopicUser { get; set; }
    }
}