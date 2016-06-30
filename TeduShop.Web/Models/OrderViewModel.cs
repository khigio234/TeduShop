using System;
using System.Collections.Generic;

namespace TeduShop.Web.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerMobile { get; set; }

        public string CustomerMessage { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string CreatedBy { get; set; }

        public bool Status { get; set; }

        public virtual IEnumerable<OrderDetailViewModel> OrderDetails { get; set; }
    }
}