namespace NorthWind.Sales.BusinessObjects.DTOs.CreateOrder
{
    /* It's a DTO that represents the data that's needed to create an order detail */
    public class CreateOrderDetailDTO
    {
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
    }
}
