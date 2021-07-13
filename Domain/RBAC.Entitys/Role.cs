using System;

namespace RBAC.Entitys
{
    /**
     * 角色
     */
    public class Role : BaseEntity
    {

        // 角色名称
        public string RoleName { get; set; }

        // 角色编码
        public string RoleCode { get; set; }

        // 上级ID
        public Guid SuperiorID { get; set; }
    }
}
