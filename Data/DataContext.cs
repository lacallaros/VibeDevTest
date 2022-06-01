using VibeDevTest.Models;

namespace VibeDevTest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<CarMake> CarMakes { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarModelDetail> CarModelDetails { get; set; }
    }
}
    