﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSC407_FinalProject.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string PostUser { get; set; }
        public string PostMessage { get; set; }

        public int TopicId { get; set; }
    }
}