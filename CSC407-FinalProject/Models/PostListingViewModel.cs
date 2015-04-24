using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSC407_FinalProject.Models
{
    public class PostListingViewModel
    {
        public int TopicId { get; set; }
        public List<Post> Posts { get; set; }
    }
}