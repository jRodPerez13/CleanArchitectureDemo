namespace NorthWind.EFCore.Repositories.Entities
{
/* The OrderDetail class has a one-to-one relationship with the Order class */
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
    }
}
