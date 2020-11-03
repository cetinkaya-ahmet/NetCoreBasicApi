using System;
using Microsoft.AspNetCore.Mvc;
using NetCoreBasicApi.Model.Contracts;

namespace NetCoreBasicApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public LoginResponse Login(LoginRequest loginRequest) 
        {
            LoginResponse result = new LoginResponse();
            result.IsSuccessful = true;
            return result;
        }
    }
}
