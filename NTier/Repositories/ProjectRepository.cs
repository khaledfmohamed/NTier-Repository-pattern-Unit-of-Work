using NTier.Models.Base;
using NTier.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using NTier.Repositories.Bases;
using NTier.Models;

namespace NTier.Repositories
{
    public class ProjectRepository : Repository<ProjectBase, int>, IProjectRepository
    {
        public ProjectRepository(ContextBase dbContext) : base(dbContext)
        {
        }

        public IEnumerable<ReleaseBase> GetReleases(int id)
        {
            return _dbContext.Set<ProjectBase>().Find(id).Releases;
        }
    }
}