namespace NorthWind.Sales.BusinessObjects.Interfaces.Ports
{
    /* An interface that is used to handle the output of the CreateOrderUseCase. */
    public interface ICreateOrderOutputPort
    {
        ValueTask Handle(int orderId);
    }
}
