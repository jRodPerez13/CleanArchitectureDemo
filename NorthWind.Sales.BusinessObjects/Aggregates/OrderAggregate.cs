namespace NorthWind.Sales.BusinessObjects.Aggregates
{
    public class OrderAggregate : Order
    {
        /* A readonly field that is initialized with a new instance of a list of OrderDetail. */
        readonly List<OrderDetail> OrderDetailsField =
            new List<OrderDetail>();
        public IReadOnlyCollection<OrderDetail> OrderDetails =>
            OrderDetailsField;

        // Agregar el detalle de la orden.
        // Si ya se agregó un ID de producto previamente, sumar la cantidad.        
        void AddDetail(OrderDetail orderDetail)
        {
            var ExistingOrderDetail =
                OrderDetailsField.FirstOrDefault(
                    o => o.ProductId == orderDetail.ProductId);

            if (ExistingOrderDetail != default)
            {
                OrderDetailsField.Add(
                    ExistingOrderDetail with
                    {
                        Quantity = (short)
                        (ExistingOrderDetail.Quantity +
                        orderDetail.Quantity)
                    });

                OrderDetailsField.Remove(ExistingOrderDetail);
            }
            else
            {
                OrderDetailsField.Add(orderDetail);
            }
        }

        public void AddDetail(int productId,
            decimal unitPrice, short quantity) =>
            AddDetail(new OrderDetail(
                productId, unitPrice, quantity));
    }
}
