using System.Data.Entity;
using Abp.EntityFramework;
using AbpFramework.Domain.Models;

namespace AbpFramewok.Infrastructure
{
    public class JobseekerDbContext:AbpDbContext
    {
        public virtual IDbSet<JobseekerBaseInfo> JobseekerBaseInfos { get; set; }

        /* NOTE: 
        *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
        *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
        *   pass connection string name to base classes. ABP works either way.
        */
        public JobseekerDbContext() : base("JobseerkContext")
        {

        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<JobseekerBaseInfo>().ToTable("JobseekerBaseInfo");
        }
    }
}