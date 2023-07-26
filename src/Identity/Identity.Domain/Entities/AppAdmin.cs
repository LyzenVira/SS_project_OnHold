using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.Entities
{
    public class AppAdmin : IdentityUser<Guid>
    {
        public string Status { get; set; } = null!;
    }
}
