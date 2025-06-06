﻿using System.ComponentModel.DataAnnotations;

namespace BookShopping.Dto
{
    public class ExternalRegisterViewModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

}
