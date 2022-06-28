namespace NorthWind.EFCore.Repositories.Configurations
{
    /* The OrderConfiguration class is an implementation of the IEntityTypeConfiguration interface */
    internal class OrderConfiguration :
        IEntityTypeConfiguration<Order>
    {
        // The function is used to configure the entity type for the Orders class     
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.CustomerId)
                .IsRequired()
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(o => o.ShipAddress)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(o => o.ShipCity)
                .HasMaxLength(15);

            builder.Property(o => o.ShipCountry)
                .HasMaxLength(15);

            builder.Property(o => o.ShipPostalCode)
                .HasMaxLength(10);
        }
    }
}
