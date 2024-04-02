using Microsoft.AspNetCore.Identity;

namespace SMM.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
