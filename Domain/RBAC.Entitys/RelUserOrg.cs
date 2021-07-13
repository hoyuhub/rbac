using System;
using Microsoft.EntityFrameworkCore;

namespace RBAC.Entitys
{
    // 用户 组织 关联
    [Keyless]
    public class RelUserOrg : BaseEntity
    {
        public Guid OrgID
        {
            get; set;
        }
        public Guid UserID
        {
            get; set;
        }
    }
}
