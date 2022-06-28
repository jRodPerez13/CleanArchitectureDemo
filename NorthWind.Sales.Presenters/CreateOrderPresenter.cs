namespace NorthWind.Sales.Presenters
{
    /* It's a presenter that handles the `CreateOrder` command */
    public class CreateOrderPresenter : ICreateOrderPresenter
    {
        public int OrderId { get; private set; }

        public ValueTask Handle(int orderId)
        {
            OrderId = orderId;
            return ValueTask.CompletedTask;
        }
    }
}
