using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext:IdentityDbContext

    {
        public ApplicationDbContext(DbContextOptions options) : base (options)
        {
            
        }

        public DbSet<Transaction> transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<SalesLeadEntity> SalesLead { get; set; }

    }
}
