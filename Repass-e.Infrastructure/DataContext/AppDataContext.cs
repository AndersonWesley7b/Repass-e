using Microsoft.EntityFrameworkCore;
using Repass_e.Domain.Entities;

namespace Repass_e.Infrastructure.DataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options)
            :base(options)
        {}
        public DbSet<Event> Events { get; set; }
    }
}
