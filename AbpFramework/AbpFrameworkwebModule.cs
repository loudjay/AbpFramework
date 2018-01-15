using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Web.Mvc;
using Abp.WebApi;
using AbpFramewok.Infrastructure;
using AbpFramework.Application;
using AbpFramework.Application.AbpFramework.Application;

namespace AbpFramework
{
    [DependsOn(typeof(AbpWebApiModule),typeof(AbpWebMvcModule),typeof(AbpFrameworkApplicationModule),typeof(AbpFrameworkDataModule))]
    public class AbpFrameworkwebModule:AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                //注入Application层的public方法生成动态api
                .ForAll<IApplicationService>(typeof(AbpFrameworkApplicationModule).Assembly,"AbpFramework")
                //根据方法名称绑定相应的http method动词
                .WithConventionalVerbs()
                .Build();
        }
    }
}