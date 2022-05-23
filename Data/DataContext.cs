namespace VibeDevTest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<PartsStock> PartsStocks { get; set; }
    }
}
