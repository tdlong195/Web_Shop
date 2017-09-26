using System;

namespace Shop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatdBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
        bool Status { get; set; }
        string MetaKeyword { get; set; }
        string MetaDesription { get; set; }

    }
}