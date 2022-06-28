namespace NorthWind.Sales.BusinessObjects.DTOs.CreateOrder
{
    /* `CreateOrderDTO` is a class that contains a list of `CreateOrderDetailDTO` objects */
    public class CreateOrderDTO
    {
        public string CustomerId { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string ShipPostalCode { get; set; }

        /* A list of `CreateOrderDetailDTO` objects. */
        public List<CreateOrderDetailDTO> OrderDetails { get; set; }

    }
}
