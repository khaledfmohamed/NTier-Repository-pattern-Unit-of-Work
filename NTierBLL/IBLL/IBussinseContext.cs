using MessageTube;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierBLL.IBLL
{
    public interface IBussinseContext : IDisposable
    {
        IMessageList MessageList { get; }
        IProjectBL Project { get; }
        
    }
}
