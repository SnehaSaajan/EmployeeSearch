using Autofac;
using Autofac.Integration.Mvc;
using BusinessLogic.Services;
using DataAccess.Repositories;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;

namespace Presentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            HtmlHelper.ClientValidationEnabled = true;
            var builder = new ContainerBuilder();
            builder.RegisterFilterProvider();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterType<EmployeeServices>().As<IEmployeeServices>();
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
