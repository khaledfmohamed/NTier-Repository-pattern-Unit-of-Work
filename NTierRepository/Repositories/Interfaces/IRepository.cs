using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierRepository.Repositories.Interfaces
{
    public interface IRepository<TEntity, in TPk> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        List<TEntity> GetAllWithInclude(params string[] paths);
        TEntity Get(TPk id);
        List<TEntity> Find(Expression<Func<TEntity , bool>> predicate);
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        EntityState GetState(TEntity entity);
        void SetState(TEntity entity , EntityState entityState);
        int GetCount();
    }
}
