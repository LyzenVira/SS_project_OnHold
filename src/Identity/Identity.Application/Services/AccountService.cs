using AutoMapper;
using Identity.Application.Interfaces;
using Identity.Application.Models.Request;
using Identity.Application.Models.Response;
using Identity.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Identity.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;

        public AccountService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<IdentityResult> SignUpAsync(SignUp signUpModel)
        {
            AppUser user = new AppUser { Email = signUpModel.Email, FirstName = signUpModel.FirstName, LastName = signUpModel.LastName, PhoneNumber = signUpModel.PhoneNumber, UserName = signUpModel.FirstName };

            var signUpResult = await _userManager.CreateAsync(user, signUpModel.Password);

            if (!signUpResult.Succeeded)
            {
                throw new Exception();
            }
            return signUpResult;
        }
    }
}
