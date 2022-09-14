namespace MxInfo.EntityFramework.Contracts;

public interface IUnitOfWork
{
    void SaveChanges();
    Task SaveChangesAsync();
}