namespace NorthWind.Sales.BusinessObjects.ValueObjects
{
    /* A record type. */
    public record struct OrderDetail(
        int ProductId, decimal UnitPrice, short Quantity);
}
