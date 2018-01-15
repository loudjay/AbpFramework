using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Abp.Modules;
using AbpFramework.Domain;

namespace AbpFramework.Application
{
    namespace AbpFramework.Application
    {
        [DependsOn(typeof(AbpFrameworkDomainModule))]
        public class AbpFrameworkApplicationModule : AbpModule
        {
            public override void Initialize()
            {
                IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            }
        }
    }
}
