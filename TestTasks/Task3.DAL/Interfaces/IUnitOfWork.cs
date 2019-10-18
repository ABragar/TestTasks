using Task3.DAL.Entities;

namespace Task3.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Item> ItemRepository { get; }
    }
}