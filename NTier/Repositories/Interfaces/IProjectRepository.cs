using NTier.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Repositories.Interfaces
{
    public interface IProjectRepository : IRepository<ProjectBase, int>
    {
         IEnumerable<ReleaseBase> GetReleases(int id);
    }
}
