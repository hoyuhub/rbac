using Microsoft.EntityFrameworkCore;
using System;

namespace RBAC.Entitys
{
    /**
     * 角色-权限关联
     */
    [Keyless]
    public class RelRoleAut : BaseEntity
    {
        public Guid AuthorityID
        {
            get; set;
        }
        public Guid RoleID
        {
            get; set;
        }
    }
}
