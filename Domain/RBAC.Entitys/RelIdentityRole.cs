using Microsoft.EntityFrameworkCore;
using System;

namespace RBAC.Entitys
{
    // 身份角色关联
    [Keyless]
    public class RelIdentityRole : BaseEntity
    {
        // 身份ID
        public Guid IdentityID { get; set; }
        // 角色ID
        public Guid RoleID { get; set; }

    }
}
