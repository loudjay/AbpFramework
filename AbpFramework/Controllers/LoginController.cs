using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;
using AbpFramework.Application.Login;
using AbpFramework.Application.Login.Dto;

namespace AbpFramework.Controllers
{
    public class LoginController : AbpController
    {
        private readonly IAccountAppService _accountAppService;
        public LoginController(IAccountAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginInputDto model)
        {
            var result = _accountAppService.Login(model);
            return View();
        }
    }
}