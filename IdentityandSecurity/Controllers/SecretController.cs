﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityandSecurity.Controllers
{
    //[Authorize]
    [Authorize(Users = "admin")]
    public class SecretController : Controller
    {
        public ContentResult Secret()
        {
            return Content("This is a secret...");
        }

        [AllowAnonymous]
        public ContentResult Overt()
        {
            return Content("This is not a secret....");
        }
    }
}