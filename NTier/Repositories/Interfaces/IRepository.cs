using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Repositories.Interfaces
{
    public interface IRepository<TEntity, in TPk> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(TPk id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity , bool>> predicate);
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        EntityState GetState(TEntity entity);
        void SetState(TEntity entity , EntityState entityState);
    }
}
