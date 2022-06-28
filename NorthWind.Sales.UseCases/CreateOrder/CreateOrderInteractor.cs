namespace NorthWind.Sales.UseCases.CreateOrder
{
    public class CreateOrderInteractor : ICreateOrderInputPort
    {
        /* Creating a readonly variable for the output port and the repository. */
        readonly ICreateOrderOutputPort OutputPort;
        readonly INorthWindSalesCommandsRepository Repository;

        /* The constructor for the class. */
        public CreateOrderInteractor(ICreateOrderOutputPort outputPort,
            INorthWindSalesCommandsRepository repository)
        {
            OutputPort = outputPort;
            Repository = repository;
        }

        /// <summary>
        /// It creates an OrderAggregate object, adds the order details to it, and then saves it to the
        /// database
        /// </summary>
        /// <param name="CreateOrderDTO">This is the DTO that is passed to the handler.</param>
        public async ValueTask Handle(CreateOrderDTO orderDto)
        {
            OrderAggregate OrderAggregate = new OrderAggregate
            {
                CustomerId = orderDto.CustomerId,
                ShipAddress = orderDto.ShipAddress,
                ShipCity = orderDto.ShipCity,
                ShipCountry = orderDto.ShipCountry,
                ShipPostalCode = orderDto.ShipPostalCode
            };

            foreach (var Item in orderDto.OrderDetails)
            {
                OrderAggregate.AddDetail(Item.ProductId,
                    Item.UnitPrice, Item.Quantity);
            }

            await Repository.CreateOrder(OrderAggregate);
            await Repository.SaveChanges();
            await OutputPort.Handle(OrderAggregate.Id);
        }
    }
}
