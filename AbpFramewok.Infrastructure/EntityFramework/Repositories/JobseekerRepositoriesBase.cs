using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AbpFramewok.Infrastructure.Repositories
{
    public abstract class JobseekerRepositoriesBase<TEntity, TPrimaryKey>:EfRepositoryBase<JobseekerDbContext, TEntity, TPrimaryKey>
        where TEntity:class,IEntity<TPrimaryKey>
    {
        protected JobseekerRepositoriesBase(IDbContextProvider<JobseekerDbContext> dbContextProvider) : base(
            dbContextProvider)
        {
            
        }
    }

    public abstract class JobseekerRepositoriesBase<TEntity> : JobseekerRepositoriesBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected JobseekerRepositoriesBase(IDbContextProvider<JobseekerDbContext> dbContextProvider) : base(
            dbContextProvider)
        {

        }
    }
}