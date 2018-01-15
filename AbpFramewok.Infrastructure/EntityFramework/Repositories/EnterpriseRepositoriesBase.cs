using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;
using AbpFramewok.Infrastructure;

namespace AbpFramewok.Infrastructure.Repositories
{
    public abstract class EnterpriseRepositoriesBase<TEntity, TPrimaryKey>:EfRepositoryBase<EnterpriseDbContext,TEntity,TPrimaryKey>
        where TEntity:class ,IEntity<TPrimaryKey>
    {
        protected EnterpriseRepositoriesBase(IDbContextProvider<EnterpriseDbContext> dbContextProvider) : base(
            dbContextProvider)
        {
            
        }
        ////add common methods for all repositories
    }

    public abstract class EnterpriseRepositoriesBase<TEntity> : EnterpriseRepositoriesBase<TEntity,int>
        where TEntity : class, IEntity<int>
    {
        protected EnterpriseRepositoriesBase(IDbContextProvider<EnterpriseDbContext> dbContextProvider) : base(
            dbContextProvider)
        {

        }
    }
}