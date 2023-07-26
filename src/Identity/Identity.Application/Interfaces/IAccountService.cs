using Identity.Application.Models.Request;
using Identity.Application.Models.Response;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> SignUpAsync(SignUp signUpModel);
    }
}
