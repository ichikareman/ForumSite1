using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainObjects;
using ForumServices;
using ForumServices.Implementations;
using ForumSite.Models;

namespace ForumSite.Controllers
{
    public class ThreadListController : Controller
    {
        //
        // GET: /ThreadList/

        private IForumService _service;

        public ThreadListController()
        {
            _service = new ForumService();
        }

        public ActionResult Index()
        {
            return View(_service.GetAll());
        }

        [HttpGet]
        public ActionResult Thread(int threadId)
        {

            return View("Thread", _service.Get(threadId));
            //return View(_service.GetAll());

        }
    }
}
