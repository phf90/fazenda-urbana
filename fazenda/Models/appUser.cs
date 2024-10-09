using Microsoft.AspNetCore.Identity;

namespace Agrocity.Models
{
    public class appUser : IdentityUser
    {
        public ICollection<Products> Products { get; set; }
    }
}
