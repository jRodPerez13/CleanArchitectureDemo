namespace NorthWind.Sales.BusinessObjects.Interfaces.Repositories
{
   /* An interface that is used to create an order. */
    public interface INorthWindSalesCommandsRepository : IUnitOfWork
    {
        ValueTask CreateOrder(OrderAggregate order);
    }
}
