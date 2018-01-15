using System.Data.Entity;
using Abp.EntityFramework;
using AbpFramework.Domain.Models;

namespace AbpFramewok.Infrastructure
{
    public class EnterpriseDbContext:AbpDbContext
    {
        public virtual IDbSet<EnterpriseBaseInfo> EnterpriseBaseInfos { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public EnterpriseDbContext():base("Default")
        {
            
        }
        /* NOTE:
        *   This constructor is used by ABP to pass connection string defined in SimpleTestDataModule.PreInitialize.
        *   Notice that, actually you will not directly create an instance of SimpleTestDbContext since ABP automatically handles it.
        */
        public EnterpriseDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EnterpriseBaseInfo>().ToTable("EnterpriseBaseInfo");
        }
    }
}