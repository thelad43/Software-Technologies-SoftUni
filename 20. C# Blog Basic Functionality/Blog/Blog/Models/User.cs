namespace Blog.Models
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
    }
}