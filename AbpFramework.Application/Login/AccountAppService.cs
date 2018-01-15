using Abp.Domain.Repositories;
using AbpFramework.Application.Login.Dto;
using AbpFramework.Domain.Models;

namespace AbpFramework.Application.Login
{
    public class AccountAppService:AbpFrameworkAppServiceBase,IAccountAppService
    {
        private readonly IRepository<EnterpriseBaseInfo> _enterpriseRepository;

        public AccountAppService(IRepository<EnterpriseBaseInfo> enterpriseRepository)
        {
            _enterpriseRepository = enterpriseRepository;
        }
        public bool Login(LoginInputDto input)
        {
            var result = _enterpriseRepository.Single(x =>
                x.LoginName.Equals(input.LoginName) && x.Password.Equals(input.Password));
            return result != null;
        }
    }
}