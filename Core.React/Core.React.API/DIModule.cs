using Autofac;
using Core.React.API.Infrastructure;
using Core.React.Common.Infrastructure;

namespace Core.React.API
{
    public class DIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // The generic ILogger<TCategoryName> service was added to the ServiceCollection by ASP.NET Core.
            // It was then registered with Autofac using the Populate method in ConfigureServices.
            builder.RegisterType<WebConfigurationManager>().As<IConfigurationManager>();
        }
    }
}