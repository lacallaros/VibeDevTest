using VibeDevTest.Dto;
using VibeDevTest.Models;

namespace VibeDevTest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<PartsStock> PartsStocks { get; set; }
        public DbSet<Material> Materials { get; set; }
    }
}
