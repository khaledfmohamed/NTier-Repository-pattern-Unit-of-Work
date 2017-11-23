using NTierBLL.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageTube;
using Unity.Attributes;
using Unity;
using NTierRepository.Repositories.Interfaces;
using Unity.Resolution;

namespace NTierBLL.BLL
{
    public class BussinseContext : IBussinseContext 
    {
        private IProjectBL project;
        [Dependency]
        public IMessageList MessageList { get; set; }
        [Dependency]
        public IUnitOfWork UnitOfWork { get; set; }

        public IProjectBL Project
        {
            get
            {
               
                if (project == null)
                {
                    project =  UnityConfig.Container.Resolve<IProjectBL>(new ResolverOverride[]
                          {
                              new ParameterOverride("unitOfWork", UnitOfWork) , new ParameterOverride("message", MessageList)
                          }); 
                    return project;
                }
                else
                    return project;
            }
        }

        public void Dispose()
        {
            UnitOfWork.Dispose();
        }
    }
}
