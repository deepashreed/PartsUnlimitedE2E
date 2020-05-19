using Microsoft.AspNet.Identity.EntityFramework;

namespace PartsUnlimited.Models
{
    //FeatureBrachchange1
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}