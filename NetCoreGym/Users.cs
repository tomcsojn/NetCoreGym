using System;
using System.Collections.Generic;

namespace NetCoreGym
{
    public partial class Users
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public int? RoleId { get; set; }
    }
}
