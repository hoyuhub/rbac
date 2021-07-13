using Microsoft.EntityFrameworkCore;
using System;

namespace RBAC.Entitys
{
    // 用户 用户组 关联
    [Keyless]
    public class RelUserGroup : BaseEntity
    {
        // 分组ID
        public Guid GroupID { get; set; }
        // 用户ID
        public Guid UserID { get; set; }
    }
}
