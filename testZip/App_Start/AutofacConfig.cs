using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using System.Web.Mvc;
using testZip.Entity;

namespace testZip.App_Start
{
    public class AutofacConfig
    {
        public static void Bootstrapper()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<CMSDbContext>()
                .As<ICMSDbContext>()
                .InstancePerRequest();

            var services = Assembly.Load("testZip.Service");
            builder.RegisterAssemblyTypes(services).AsImplementedInterfaces();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}