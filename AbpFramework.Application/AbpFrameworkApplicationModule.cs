using System.Reflection;
using Abp.Modules;
using AbpFramework.Domain;

namespace AbpFramework.Application
{
    [DependsOn(typeof(AbpFrameworkDomainModule))]
    public class AbpFrameworkApplicationModule:AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}