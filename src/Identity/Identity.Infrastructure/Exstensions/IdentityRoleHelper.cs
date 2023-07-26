using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Infrastructure.Exstensions
{
    public static class IdentityRoleHelper
    {
        private static Dictionary<string, string[]> AdminScopes = new()
        {
            {"user", new[] { "get", "create", "delete", "update" } }
        };

        /*internal static IEnumerable<IdentityRoleClaim<Guid>> GetAdminPermissionsScope()
        {
            var roleClaims = new List<IdentityRoleClaim<Guid>>();

            foreach (var entityPermission in AdminScopes)
            {
                var entity = entityPermission.Key;
                var permissions = entityPermission.Value;

                foreach (var permission in permissions)
                {
                    var claim = new IdentityRoleClaim<Guid>
                    {
                        Id = _id,
                        RoleId = Guid.Parse("d522e6ae-a0d5-4753-8bf1-feb30e3b535e"),
                        ClaimType = $"{permission}:{entity}",
                    };

                    roleClaims.Add(claim);
                    _id++;
                }
            }

            return roleClaims;
        }*/

    }
}
