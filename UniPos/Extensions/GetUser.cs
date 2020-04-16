using RssSata.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UniPos.Extensions
{
    public static class GetUserClaimsPrincipal
    {
        public static bool IsRoleAdmin(this ClaimsPrincipal identity)
        {
            var role = identity.FindFirst(ClaimTypes.Role);
            return role.Value.Contains("999;");
        }

        public static int GetId(this ClaimsPrincipal identity)
        {
            var role = identity.FindFirst(ClaimTypes.Name);
            return role.Value.ToInt();
        }
        
        public static string GetAccess(this ClaimsPrincipal identity)
        {
            var role = identity.FindFirst(ClaimTypes.Role);
            return role.Value;
        }
    }
}
