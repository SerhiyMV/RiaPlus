using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Ninject.Activation.Strategies;
using RiaPlus.Domain.Abstract;
using RiaPlus.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using Moq;
using RiaPlus.Domain.Concrete;

namespace RiaPlus.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext requestContext,
            Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
            //return controllerType == null 
            //    ?null 
            //    : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IProductsRepository>().To<EFProductRepository>();
        }

    }
}
