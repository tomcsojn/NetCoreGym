using System;
using System.Collections.Generic;

namespace NetCoreGym
{
    public partial class Invoices
    {
        public int Id { get; set; }
        public int? MembershipId { get; set; }
        public int? MemberId { get; set; }
        public int? PaymentId { get; set; }
        public DateTime? Sold { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
