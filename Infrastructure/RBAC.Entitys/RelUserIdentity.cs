using Microsoft.EntityFrameworkCore;
using System;

namespace RBAC.Entitys
{
    // 用户 身份 关联
    [Keyless]
    public class RelUserIdentity : BaseEntity
    {
        public Guid IdentityID
        {
            get; set;
        }
        public Guid UserID
        {
            get; set;
        }
    }
}
