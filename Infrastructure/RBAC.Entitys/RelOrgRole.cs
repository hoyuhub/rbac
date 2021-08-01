using Microsoft.EntityFrameworkCore;
using System;

namespace RBAC.Entitys
{
    //　组织角色关联
    [Keyless]
    public class RelOrgRole:BaseEntity
    {
        // 组织ID
        public Guid OrgID { get; set; }
        // 角色ID
        public Guid RoleID { get; set; }

    }
}
