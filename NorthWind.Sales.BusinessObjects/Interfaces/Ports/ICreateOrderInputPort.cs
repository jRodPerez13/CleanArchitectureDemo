namespace NorthWind.Sales.BusinessObjects.Interfaces.Ports
{
    /* An interface that defines the input port for the CreateOrder use case. */
    public interface ICreateOrderInputPort
    {
        ValueTask Handle(CreateOrderDTO orderDto);
    }
}
