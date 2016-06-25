using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedTime { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
    }
}