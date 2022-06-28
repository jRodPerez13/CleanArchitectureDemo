namespace NorthWind.EFCore.Repositories.Repositories
{
    public class NorthWindSalexCommandsRepository
        : INorthWindSalesCommandsRepository
    {
        readonly NorthWindSalesContext Context;

        /* A constructor. */
        public NorthWindSalexCommandsRepository(NorthWindSalesContext context)
        {
            Context = context;
        }

        /* Adding the order and the order details to the database. */
        public async ValueTask CreateOrder(OrderAggregate order)
        {
            await Context.AddAsync(order);
            foreach (var Item in order.OrderDetails)
            {
                await Context.AddAsync(new OrderDetail
                {
                    Order = order,
                    ProductId = Item.ProductId,
                    Quantity = Item.Quantity,
                    UnitPrice = Item.UnitPrice
                });
            }
        }

        public async ValueTask SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}
