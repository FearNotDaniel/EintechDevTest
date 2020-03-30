using Autofac;
using EintechDevTest.Core.Interfaces.UseCases;
using EintechDevTest.Core.UseCases;

namespace EintechDevTest.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AddPersonUseCase>().As<IAddPersonUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<SearchPeopleUseCase>().As<ISearchPeopleUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<ViewAllPeopleUseCase>().As<IViewAllPeopleUseCase>().InstancePerLifetimeScope();
            builder.RegisterType<ViewAllGroupsUseCase>().As<IViewAllGroupsUseCase>().InstancePerLifetimeScope();
        }
    }
}
