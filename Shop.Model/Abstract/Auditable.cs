using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public string CreatdBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }
        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDesription { get; set; }
        public bool Status { get; set; }
    }
}