using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _24.LoginForms.Models
{
    public partial class UserTbl
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public int? Age { get; set; }

        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
