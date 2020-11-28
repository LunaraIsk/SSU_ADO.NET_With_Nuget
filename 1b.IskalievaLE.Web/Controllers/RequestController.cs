using _1b.IskalievaLE.BLL.Interface;
using _1b.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyResolver = _1b.IskalievaLE.Common.DependencyResolver;

namespace _1b.IskalievaLE.Web.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestLogic _requestLogic;

        // GET: Request

        public RequestController()
        {
            _requestLogic = DependencyResolver.RequestLogic;
        }
        public ActionResult Index()
        {
            var request = _requestLogic.GetAllRequests();
            return View(request);
        }

        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }
        [HttpPost]
        [Route(Name = "Add")]
        public ActionResult AddPost(Request request)
        {
            _requestLogic.AddRequest(request);


            return RedirectToAction("Index");
        }
    }
}