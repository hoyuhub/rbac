using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RBAC.Entitys
{
    // 组织
    public class Organization : BaseEntity
    {
        // 组织名称
        public string Name { get; set; }
        // 组织编码
        public string Code { get; set; }
        // 上一级编码
        public Guid ParentID { get; set; }
        // 组织类型
        public int Type { get; set; }

    }
}
