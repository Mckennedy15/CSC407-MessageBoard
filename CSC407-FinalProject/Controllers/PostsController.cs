using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CSC407_FinalProject.Data;
using CSC407_FinalProject.Models;
using CSC407_FinalProject.Services;


namespace CSC407_FinalProject.Controllers
{
    public class PostsController : Controller
    {
        
        private MessageBoardDbContext db = new MessageBoardDbContext();

        private PostingService postingService;
        private UserService userService;

        public PostsController()
        {
            this.postingService = new PostingService();
            this.userService = new UserService(null);
        }

        public ActionResult List(int id)
        {
            var viewModel = new PostListingViewModel();

            viewModel.TopicId = id;
            viewModel.User = this.userService.GetUser(User.Identity.Name);
            viewModel.Posts = this.postingService.GetPostsByTopicId(id);
            
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create(int id)
        {
            var post = new Post();
            post.TopicId = id;
            return View(post);
        }

        [HttpPost]
        public ActionResult Create(CSC407_FinalProject.Models.Post post)
        {
            post.PostUser = this.HttpContext.User.Identity.Name;
            
            this.postingService.SavePost(post);
            return RedirectToAction("List", new { id = post.TopicId });

        }

        public ActionResult Delete(int id)
        {
            this.postingService.DeletePost(id);
            return RedirectToAction("Index", "Topics");
        }

        


    }
}