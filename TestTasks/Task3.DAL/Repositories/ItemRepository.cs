using System.Collections.Generic;
using System.Linq;
using Task3.DAL.DB;
using Task3.DAL.Entities;
using Task3.DAL.Interfaces;

namespace Task3.DAL.Repositories
{
    public class ItemRepository : IItemRepository
    {
        List<Item> db = Database.EntitiesDummyList;
        public void Dispose()
        {
        }

        public IEnumerable<Item> GetAll()
        {
            return db;
        }

        public Item Get(int id)
        {
            return db.Single(x => x.Id == id);
        }

        public void Create(Item item)
        {
            db.Add(item);
        }

        public void Update(Item item)
        {
            var value = db.Single(x => x.Id == item.Id);

            value.Name = item.Name;
            value.Description = item.Description;
        }

        public void Delete(int id)
        {
            var item = db.Single(x => x.Id == id);
            db.Remove(item);
        }

        public void Save()
        {
            //todo save context
        }
    }
}