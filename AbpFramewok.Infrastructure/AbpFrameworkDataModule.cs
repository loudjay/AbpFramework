using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using AbpFramewok.Infrastructure;
using AbpFramework.Domain;

namespace AbpFramewok.Infrastructure
{
    [DependsOn(typeof(AbpEntityFrameworkModule),typeof(AbpFrameworkDomainModule))]
    public class AbpFrameworkDataModule: AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<EnterpriseDbContext>(null);
            Database.SetInitializer<JobseekerDbContext>(null);
        }
    }
}