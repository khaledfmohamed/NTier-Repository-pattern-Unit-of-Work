using NTier.Models;
using NTier.Repositories.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTier.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        
        public IProjectRepository Project { get; set; }
       
        private readonly ContextBase _dbContext;
        public UnitOfWork(ContextBase dbContext)
        {
            _dbContext = dbContext;
            Project = UnityConfig.Container.Resolve<IProjectRepository>(new ResolverOverride[]
                        {
                            new ParameterOverride("dbContext", _dbContext)
                        }); ;


        }
        
        public void Complete()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}