using Agrocity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Agrocity.Data
{
    public class ApplicationDbContext : IdentityDbContext <appUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
        
        
    }
}
