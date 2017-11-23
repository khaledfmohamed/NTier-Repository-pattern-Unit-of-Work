
using NTierRepository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using NTierRepository.Repositories.Bases;
using NTierRepository.Models;

using NTierModel;

namespace NTierRepository.Repositories
{
    public class ProjectRepository : Repository<Project, int>, IProjectRepository
    {
        public ProjectRepository(ContextBase dbContext) : base(dbContext)
        {
        }

        
    }
}