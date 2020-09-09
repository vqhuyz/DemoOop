using DemoOOP.DI.Implement;
using DemoOOP.DI.Interface;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace DemoOOP
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProductService, ProductService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}