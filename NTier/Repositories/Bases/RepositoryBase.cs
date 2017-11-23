using NTier.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Data.Entity;
using Microsoft.Practices.Unity;
using NTier.Models;

namespace NTier.Repositories.Bases
{
    public abstract class Repository<TEntity, TPk> : IRepository<TEntity, TPk> where TEntity : class
    {


        public readonly ContextBase _dbContext;

        public Repository(ContextBase dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
           return _dbContext.Set<TEntity>().Where<TEntity>(predicate);
        }

        public TEntity Get(TPk id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().RemoveRange(entities);
        }

        public EntityState GetState(TEntity entity)
        {
            return _dbContext.Entry<TEntity>(entity).State;
        }

       

        public void SetState(TEntity entity, EntityState entityState)
        {
            _dbContext.Entry<TEntity>(entity).State = entityState;
        }
    }
}