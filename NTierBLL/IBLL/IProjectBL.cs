using NTierModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierBLL.IBLL
{
    public interface IProjectBL : ICommonBL<Project>
    {
        
         void SetTimeBox(Project project, int timeBox);
        
    }
}
