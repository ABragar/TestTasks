using Task3.DAL.Entities;

namespace Task3.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<BusinessEntity1> BusinessEntities1Repo { get; }
    }
}