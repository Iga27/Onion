using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onion.App_Start
{
    public class NinjectWebCommon
    {
        //maybe some other methods should be here
        private static void RegisterServices(IKernel kernel)
        {
            System.Web.Mvc.DependencyResolver.SetResolver(new Onion.Util.NinjectDependencyResolver(kernel));
        }
    }
}