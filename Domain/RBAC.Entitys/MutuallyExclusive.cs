using System;

namespace RBAC.Entitys
{
    /**
     * 权限互斥
     */
    public class MutuallyExclusive:BaseEntity
    {
        // 权限A
        public Guid AuthorityIDA { get; set; }

        // 权限B
        public Guid AuthorityIDB { get; set; }

    }
}
