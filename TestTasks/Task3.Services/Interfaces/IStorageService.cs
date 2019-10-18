using System.Collections.Generic;
using Task3.DAL.Entities;

namespace Task3.Services.Interfaces
{
    public interface IStorageService
    {
        void SaveItem(Item item);
        IEnumerable<Item> GetItems();
        Item GetItem(int id);
    }
}