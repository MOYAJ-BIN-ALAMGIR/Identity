﻿using System.ComponentModel.DataAnnotations;
using System.IO.Compression;

namespace Identity.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }
        [RegularExpression("^[a-zA-Z0-9_.\\-]+@([a-zA-Z0-9\\-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage ="E-mail is not valid")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
