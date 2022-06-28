namespace NorthWind.EFCore.Repositories.Configurations
{
    /* The OrderDetailConfiguration class is an internal class that implements the
    IEntityTypeConfiguration<OrderDetail> interface */
    internal class OrderDetailConfiguration :
        IEntityTypeConfiguration<OrderDetail>
    {        
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            /* Configuring the OrderDetail entity type to have a composite primary key consisting of
            the OrderId and ProductId properties. */
            builder.HasKey(d => new { d.OrderId, d.ProductId });
            builder.Property(d => d.UnitPrice)
                .HasPrecision(8, 2);
        }
    }
}
