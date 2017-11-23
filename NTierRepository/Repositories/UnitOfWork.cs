using NTierRepository.Models;
using NTierRepository.Repositories.Interfaces;
using Unity.Resolution;
using Unity;
using System;

namespace NTierRepository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
      
        public IProjectRepository Project { get; set; }
        

        private readonly ContextBase _dbContext;
        public UnitOfWork()
        {
            _dbContext = new SqlServerContext();
            Project = new ProjectRepository(_dbContext);
            
           
        }
        
        public void Complete()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (System.Data.DataException ex)
            {
                if (ex.InnerException != null)
                {
                    if (ex.InnerException.InnerException != null)
                    {
                        if (ex.InnerException.InnerException.Message.Contains("IXName"))
                        {

                            throw new RepositoryException("ESR-1" , "Name must be uniqe");
                        }
                        else if (ex.InnerException.InnerException.Message.Contains("FK_dbo.backlogs_dbo.projects_project_id"))
                        {
                            throw new RepositoryException("ESR-2" , "Cannot delete project due to related backlog");
                        }
                        throw;
                    }
                }
                throw;
            }
            
            }
        

       public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}