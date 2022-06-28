namespace NorthWind.EFCore.Repositories.Configurations
{
    /* The OrderDetailConfiguration class is an internal class that implements the
    IEntityTypeConfiguration<OrderDetail> interface */
    internal class OrderDetailConfiguration :
        IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(d => new { d.OrderId, d.ProductId });
            builder.Property(d => d.UnitPrice)
                .HasPrecision(8, 2);
        }
    }
}
