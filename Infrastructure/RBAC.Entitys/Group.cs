using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RBAC.Entitys
{
    // 分组 
    public class Group : BaseEntity
    {
        // 分组名称
        public string Name { get; set; }
        // 分组编码
        public string Code { get; set; }
    }
}
