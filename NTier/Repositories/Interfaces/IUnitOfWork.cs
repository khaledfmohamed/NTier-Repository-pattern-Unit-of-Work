using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Repositories.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        IProjectRepository Project { get; set; }
        void Complete();
    }
}
