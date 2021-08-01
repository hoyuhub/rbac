using System;
using System.ComponentModel.DataAnnotations;

namespace RBAC.Entitys
{
    public class BaseEntity
    {
        [Key]
        public Guid ID { get; set; }
        public DateTime Create { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime? Update { get; set; }
        public Guid? UpdateBy { get; set; }
    }
}
