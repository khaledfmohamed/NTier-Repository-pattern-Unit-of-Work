
using NTierRepository.Models;
using NTierRepository.Repositories.Interfaces;
using NTierRepository.Repositories;
using NTierBLL.IBLL;
using NTierBLL.BLL;
using Unity;
using MessageTube;
using NTierModel;

namespace NTier
{
    public static class UnityConfig
    {
        
        public static UnityContainer Container { get; set ; }


        public static void RegisterComponents()
        {
			 Container = new UnityContainer();
           
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
          
            Container.RegisterType<ContextBase, SqlServerContext>();
            Container.RegisterType<IProjectRepository, ProjectRepository>();
            Container.RegisterType<IUnitOfWork, UnitOfWork>();
            Container.RegisterType<IBussinseContext, BussinseContext>();
            Container.RegisterType<IMessageList, MessageList>();
            Container.RegisterType<IProjectBL, ProjectBL>();
            NTierBLL.UnityConfig.Container = Container;

            
        }
    }
}