using Task3.DAL.Entities;
using Task3.DAL.Interfaces;
using Task3.DAL.Repositories;

namespace Task3.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private IRepository<Item> _itemRepository;

        public IRepository<Item> ItemRepository
        {
            get
            {
                if (_itemRepository == null)
                    _itemRepository = new ItemRepository();
                return _itemRepository;
            }
        }
    }
}