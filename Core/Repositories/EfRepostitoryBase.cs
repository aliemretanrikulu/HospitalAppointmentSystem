

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

   
}
