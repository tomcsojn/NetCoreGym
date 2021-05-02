using System;
using System.Collections.Generic;

namespace NetCoreGym
{
    public partial class Memberships
    {
        public int MembershipId { get; set; }
        public int? TypeId { get; set; }
        public ulong? Active { get; set; }
        public int? Price { get; set; }
        public int? Valid { get; set; }
    }
}
