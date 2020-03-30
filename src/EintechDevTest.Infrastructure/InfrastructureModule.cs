using Autofac;
using EintechDevTest.Core.Interfaces.Repositories;
using EintechDevTest.Infrastructure.Data.Repositories;

namespace EintechDevTest.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PersonRepository>().As<IPersonRepository>().InstancePerLifetimeScope();
            builder.RegisterType<GroupRepository>().As<IGroupRepository>().InstancePerLifetimeScope();
        }
    }
}
