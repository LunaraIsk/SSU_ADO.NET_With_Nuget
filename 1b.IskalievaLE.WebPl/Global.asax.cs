using _1b.IskalievaLE.BLL;
using _1b.IskalievaLE.BLL.Interface;
using _1b.IskalievaLE.WebPl.App_Start;
using AutoMapper;
using Ninject;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace _1b.IskalievaLE.WebPl
{
    public class MvcApplication : NinjectHttpApplication
    {
        public override void Init()
        {
            base.Init();
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            Registration(kernel);
            return kernel;
        }

        private void Registration(IKernel kernel)
        {
            var mapperConfiguration = new MapperConfiguration(cfg => { cfg.AddProfile<AutoMapperWebConfiguration>(); });


            kernel.Bind<IMapper>().ToConstructor(c => new Mapper(mapperConfiguration)).InSingletonScope();

            kernel.Bind<IInventoryLogic>().To<InventoryLogic>().InSingletonScope();

            kernel.Bind<IRequestLogic>().To<RequestLogic>().InSingletonScope();
        }
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
