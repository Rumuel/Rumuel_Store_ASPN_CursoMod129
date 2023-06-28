using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rumuel_Store_ASPN_CursoMod129.Models;

namespace Rumuel_Store_ASPN_CursoMod129.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Represents Tables
        public DbSet<Client> Clients { get; set; } = default!;

        public DbSet<Category> Categories { get; set; } = default!;

        public DbSet<Product> Products { get; set; } = default!;

        public DbSet<Sale> Sales { get; set; } = default!;

        public DbSet<Status> Status { get; set; } = default!;
    }
}