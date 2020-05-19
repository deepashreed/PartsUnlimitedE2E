using Microsoft.AspNet.Identity.EntityFramework;

namespace PartsUnlimited.Models
{
    //Test2
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}