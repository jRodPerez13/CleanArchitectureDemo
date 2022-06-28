namespace NorthWind.Entities.Interfaces
{
    /* An interface that is used to save changes to the database. */
    public interface IUnitOfWork
    {
        ValueTask SaveChanges();
    }
}
