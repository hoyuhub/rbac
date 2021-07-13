using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBAC.Models
{
    public class User
    {
        // 登录名
        public string LoginName { get; set; }
        // 昵称
        public string UserName { get; set; }
        // 密码 
        public string Password { get; set; }
    }
}
