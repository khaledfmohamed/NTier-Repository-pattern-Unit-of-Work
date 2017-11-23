using MessageTube;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierBLL.IBLL
{
    public interface ICommonBL<Entity>
    {
        void AddNew(Entity entity);    
        List<Entity> GetAll(params String[] RelatedFields);
        List<Entity> Search(string cretria);
        Entity  Delete(int id);
        void Edit(Entity entity);
    }
}
