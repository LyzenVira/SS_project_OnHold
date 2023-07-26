using Identity.Application.Interfaces;
using Identity.Application.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace Identity.WebApi.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> Register(SignUp signUpModel)
        {
            var result = await _accountService.SignUpAsync(signUpModel);
            return Ok(result);
        }
    }
}
