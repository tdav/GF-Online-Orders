using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniPos.Extensions;

namespace UniPos.Controllers
{
    public class MyControllerBase : ControllerBase
    {
        public readonly int UserId;
        public readonly bool IsAdmin;
        public readonly string UserAccess;

        public MyControllerBase()
        {
            UserId = User.GetId();
            IsAdmin = User.IsRoleAdmin();
            UserAccess = User.GetAccess();
        }

    }
}
