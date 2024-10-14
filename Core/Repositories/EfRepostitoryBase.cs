

using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories;

public class EfRepostitoryBase<TContext, TEntity, TId> : IRepository<TEntity, TId>
    where TEntity : Entity<TId>, new()
    where TContext : DbContext
{
    protected TContext Context { get; }
    public EfRepostitoryBase(TContext context)
    {
        Context = context;
    }

    public List<TEntity> GetAll()
    {
        return Context.Set<TEntity>().ToList();
    }

        public TEntity? GetById(TId id)
    {
        return Context.Set<TEntity>().Find(id);
    }

    public TEntity? Update(TEntity entity)
    {
        entity.UpdatedDate = DateTime.Now;
        Context.Set<TEntity>().Update(entity);
        Context.SaveChanges();
        return entity;

    }

    public TEntity? Add(TEntity entity)
    {
        entity.CreatedDate = DateTime.Now;
        Context.Set<TEntity>().Add(entity);
        return entity;
    }

    public TEntity? Remove(TEntity entity)
    {
        Context.Set<TEntity>().Remove(entity);
        Context.SaveChanges();
        return entity;

    }
}
