using _1b.IskalievaLE.BLL.Interface;
using _1b.IskalievaLE.Entities;
using _1b.IskalievaLE.WebPl.ViewModels.AppInventory;
using _1b.IskalievaLE.WebPl.ViewModels.AppRequest;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyResolver = _1b.IskalievaLE.Common.DependencyResolver;

namespace _1b.IskalievaLE.WebPl.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestLogic _requestLogic;
        private readonly IMapper _mapper;

        // GET: Request

        public RequestController(IMapper mapper)
        {
            _requestLogic = DependencyResolver.RequestLogic;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            var request = _requestLogic.GetAllRequests().ToList();

            var requestVM = _mapper.Map<IEnumerable<RequestVM>>(request);

            return View(requestVM);
        }

        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }
        [HttpPost]
        [Route(Name ="Add")]
        public ActionResult AddPost(Request request)
        {
            _requestLogic.AddRequest(request);


            return RedirectToAction("Index");
        }

        
    }
}