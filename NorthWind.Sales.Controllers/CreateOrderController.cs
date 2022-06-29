namespace NorthWind.Sales.Controllers
{
    public class CreateOrderController : ICreateOrderController
    {
        readonly ICreateOrderInputPort InputPort;
        readonly ICreateOrderPresenter Presenter;
        public CreateOrderController(ICreateOrderInputPort inputPort,
            ICreateOrderPresenter presenter)
        {
            InputPort = inputPort;
            Presenter = presenter;
        }


        /// <summary>
        /// > The function creates an order by handling the order and returning the order id
        /// </summary>
        /// <param name="CreateOrderDTO">This is the DTO that is passed to the API.</param>
        /// <returns>
        /// The OrderId of the newly created order.
        /// </returns>
        public async ValueTask<int> CreateOrder(CreateOrderDTO order)
        {
            await InputPort.Handle(order);
            return Presenter.OrderId;
        }
    }
}
