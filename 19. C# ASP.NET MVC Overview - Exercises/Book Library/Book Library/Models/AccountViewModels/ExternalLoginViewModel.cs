using System;
using System.ComponentModel.DataAnnotations;

namespace Book_Library.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}