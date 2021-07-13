using System;
using Microsoft.EntityFrameworkCore;

namespace RBAC.Entitys
{
    // 用户组 角色 关联
    [Keyless]
    public class RelGroupRole : BaseEntity
    {
        // 分组ID 
        public Guid GroupID { get; set; }
        // 角色ID
        public Guid RoleID { get; set; }
    }
}
