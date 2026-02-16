using Apple_Music_Dashboard.Models.Enitities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Transactions;

namespace Apple_Music_Dashboard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }

}
