using System;
using System.Collections.Generic;

namespace ASPCoreWebAPICRUD.Models
{
    public partial class UserTbl
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
