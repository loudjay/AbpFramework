using Abp.Application.Services;
using AbpFramework.Application.Login.Dto;

namespace AbpFramework.Application.Login
{
    public interface IAccountAppService: IApplicationService
    {
        bool Login(LoginInputDto input);
    }
}