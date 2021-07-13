using System;
using System.Collections.Generic;
using System.Text;

namespace RBAC.Entitys
{
    public class User:BaseEntity
    {
        // 登录名
        public string LoginName { get; set; }
        // 昵称
        public string UserName { get; set; }
        // 密码 
        public string Password { get; set; }

    }
}
