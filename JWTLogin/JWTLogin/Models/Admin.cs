﻿using System.ComponentModel.DataAnnotations;

namespace JWTLogin.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Please Enter valid EmailID")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

    }
}
