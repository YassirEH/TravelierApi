using Microsoft.EntityFrameworkCore;

namespace TravelierApi
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Tours> Tours { get; set; }
    }
}
