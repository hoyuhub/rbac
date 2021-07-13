using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RBAC.Models;

namespace RBAC.WebAPI.Areas.User.Controllers
{
    [Area("User")]
    [ApiController]
    [Route("[area]/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public IList<Models.User> Users()
        {
            var list = new List<Models.User>() { new Models.User() { LoginName = "test" }, new Models.User() { LoginName = "admin" } };
            return list;
        }
    }
}
