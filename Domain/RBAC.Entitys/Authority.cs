using System;

namespace RBAC.Entitys
{
    /**
     * 权限
     */
    public class Authority : BaseEntity
    {

        //权限名称
        public string AuthorityName { get; set; }

        // 权限编码
        public string AuthorityCode { get; set; }

        // 上级ID
        public Guid SuperiorID { get; set; }

        // 系统编码
        public string SystemCode { get; set; }

        // 菜单路径
        public string MenuPath { get; set; }

        // 排序
        public int Sort { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
    }
}
