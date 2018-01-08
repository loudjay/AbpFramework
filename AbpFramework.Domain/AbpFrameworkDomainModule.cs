using System.Reflection;
using Abp.Modules;

namespace AbpFramework.Domain
{
    public class AbpFrameworkDomainModule:AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}