using Autofac;
using Core.React.Repository.Infrastructure;

namespace Core.React.API
{
    public class DIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // The generic ILogger<TCategoryName> service was added to the ServiceCollection by ASP.NET Core.
            // It was then registered with Autofac using the Populate method in ConfigureServices.
            builder.RegisterType<DataAccessAdapterFactory>().As<IDataAccessAdapterFactory>();
        }
    }
}