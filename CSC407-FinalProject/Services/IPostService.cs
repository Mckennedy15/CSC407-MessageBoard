using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSC407_FinalProject.Models;

namespace CSC407_FinalProject.Services
{
    public interface IPostService
    {
        List<Post> GetPost();

        Post GetPostById(int id);

        void SavePost(Post post);

        void DeletePost(int id);
    }
}