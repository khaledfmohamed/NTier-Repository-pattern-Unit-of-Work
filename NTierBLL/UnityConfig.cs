
using NTierRepository.Models;

using NTierRepository.Repositories;
using NTierRepository.Repositories.Interfaces;
using MessageTube;
using Microsoft.Practices.Unity;
using Unity;

namespace NTierBLL
{
    public static class UnityConfig
    {
        
        public static UnityContainer Container { get; set ; }

        
        public static void RegisterComponents()
        {
           if(Container == null)
             Container = new UnityContainer();
           
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            
         //   Container.RegisterType<IMessageList, MessageList>();
            

           


        }
    }
}