using System;
using System.Collections.Generic;

namespace NetCoreGym
{
    public partial class Payments
    {
        public int PaymentId { get; set; }
        public int? CreditId { get; set; }
        public int? PaymentTypeId { get; set; }
    }
}
