

using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories;

public class EfRepostitoryBase<TName, TEntity, TId> : IRepository<TEntity, TId>
    where TEntity : Entity<TId>, new()
    where TName : DbContext
{

    protected TName Name { get;}

    public EfRepostitoryBase(TName name)
    {
        Name = name;
    }

    public List<TEntity> GetAll()
    {
        return Name.Set<TEntity>().ToList();
    }

    public TEntity? GetById(TId id)
    {
        return Name.Set<TEntity>().Find(id);
    }

    public TEntity? Update(TEntity entity)
    {
        entity.UpdatedDate = DateTime.Now;
        Name.Set<TEntity>().Update(entity);
        Name.SaveChanges();
        return entity;

    }

    public TEntity? Add(TEntity entity)
    {
        entity.CreatedDate = DateTime.Now;
        Name.Set<TEntity>().Add(entity);
        return entity;
    }

    public TEntity? Remove(TEntity entity)
    {
        Name.Set<TEntity>().Remove(entity);
        Name.SaveChanges();
        return entity;

    }
}
