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
    public class TopicsController : Controller
    {
        private MessageBoardDbContext db = new MessageBoardDbContext();

        private TopicService topicService;
        private UserService userService;



        public TopicsController()
        {
            this.topicService = new TopicService();
            this.userService = new UserService(null);
 
        }

        [HttpGet]
        public ActionResult Index()
        {
            var allTopics = new TopicListViewModel();
            allTopics.User = this.userService.GetUser(User.Identity.Name);
            allTopics.Topic = this.topicService.GetTopic();
         

            return View(allTopics);
        }

     
        [HttpPost]
        public ActionResult Index(string SearchString)
        {
            string searchString = SearchString;
            var allTopics = this.topicService.GetTopic();
            if (!String.IsNullOrEmpty(searchString))
            {
             //  allTopics = allTopics.Where(x => x.TopicName.Contains(searchString));                      //HELPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP
            } 

            return View(allTopics);
        }

    

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CSC407_FinalProject.Models.Topic topic)
        {
            topic.TopicUser = this.HttpContext.User.Identity.Name;
            this.topicService.SaveTopic(topic);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            this.topicService.DeleteTopic(id);
            return RedirectToAction("Index", "Topics");
        }


     
    }
}