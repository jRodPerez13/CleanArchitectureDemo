namespace NorthWind.EFCore.Repositories.DataContexts
{
    //Add-Migration InitialCreate -p Northwind.EFCore.Repositories -s Northwind.EFCore.Repositories -c NorthwindContext
    //Update-Database -p Northwind.EFCore.Repositories -s Northwind.EFCore.Repositories -context NorthwindContext
    internal class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=NorthWindDB;Trusted_Connection=True;");
        }

        /* This is how you tell Entity Framework that you want to map the Order and OrderDetail classes
        to the database. */
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }
    }
}
