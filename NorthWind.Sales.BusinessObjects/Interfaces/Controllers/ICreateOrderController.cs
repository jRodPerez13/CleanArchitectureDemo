namespace NorthWind.Sales.BusinessObjects.Interfaces.Controllers
{
   /* An interface. */
    public interface ICreateOrderController
    {
        
        // This function creates an order and returns the order id        
        ValueTask<int> CreateOrder(CreateOrderDTO order);
    }
}
