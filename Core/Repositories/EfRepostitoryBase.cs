

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
        throw new NotImplementedException();
    }

    public TEntity? GetById(TId id)
    {
        throw new NotImplementedException();
    }

    public TEntity? Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public TEntity? Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public TEntity? Remove(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
