namespace NorthWind.EFCore.Repositories.DataContexts
{
    public class NorthWindSalesContext : DbContext
    {
        /* This is the constructor for the NorthWindSalesContext class. It is taking in a
        DbContextOptions object and passing it to the base class. */
        public NorthWindSalesContext(
            DbContextOptions<NorthWindSalesContext> options)
            : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }
    }
}
