
using NTierRepository.Models;

using NTierRepository.Repositories;
using NTierRepository.Repositories.Interfaces;
using Microsoft.Practices.Unity;
using Unity;

namespace NTierRepository
{
    public static class UnityConfig
    {
        
        public static UnityContainer Container { get; set ; }

        public static void SetExternalContainer(UnityContainer container)
        {
            Container = container;
        }
        public static void RegisterComponents()
        {
            
             Container = new UnityContainer();
           
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            
            Container.RegisterType<ContextBase, SqlServerContext>();
            Container.RegisterType<IProjectRepository, ProjectRepository>();
           
            Container.RegisterType<IUnitOfWork, UnitOfWork>();
           


        }
    }
}