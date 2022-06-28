namespace NorthWind.Sales.BusinessObjects.Interfaces.Presenters
{
    /* A C# interface. It is a contract that says that any class that implements this interface must
    have a property called OrderId that is an integer. */
    public interface ICreateOrderPresenter : ICreateOrderOutputPort
    {
        int OrderId { get; }
    }
}
