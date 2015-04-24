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

        public TopicsController()
        {
            this.topicService = new TopicService();
        }

        public ActionResult Index()
        {
            var allTopics = this.topicService.GetTopic();
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