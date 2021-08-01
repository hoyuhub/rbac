using System;

namespace RBAC.Entitys
{
    // 身份
    public class Identity : BaseEntity
    {
        // 职位名称
        public string PostionName { get; set; }
        // 职位编码 
        public string PositionCode { get; set; }
        // 上一级编码
        public Guid ParentID { get; set; }
        // 组织编码
        public Guid OrgID { get; set; }

    }
}
