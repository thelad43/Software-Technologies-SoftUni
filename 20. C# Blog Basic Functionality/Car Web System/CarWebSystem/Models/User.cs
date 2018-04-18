namespace CarWebSystem.Models
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}