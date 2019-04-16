using System.Collections.Generic;
using System.Linq;
using Task3.DAL.Entities;
using Task3.DAL.Interfaces;
using static System.Console;

namespace Task3.DAL.Repositories
{
    public class BusinessProcessRepository : IRepository<BusinessEntity1>
    {
        private List<BusinessEntity1> _entitiesDummyList = new List<BusinessEntity1>();

        public BusinessProcessRepository()
        {
            //init sample db
            if (!_entitiesDummyList.Any())
            {
                _entitiesDummyList.Add(new BusinessEntity1() { Id = 1, Name = "Entity1" });
                _entitiesDummyList.Add(new BusinessEntity1() { Id = 2, Name = "Entity2" });
                _entitiesDummyList.Add(new BusinessEntity1() { Id = 3, Name = "Entity3" });
                _entitiesDummyList.Add(new BusinessEntity1() { Id = 4, Name = "Entity4" });
                _entitiesDummyList.Add(new BusinessEntity1() { Id = 5, Name = "Entity5" });
            }
        }

        public void Dispose()
        {
        }

        public IEnumerable<BusinessEntity1> GetAll()
        {
            foreach (var businessEntity1 in _entitiesDummyList)
            {
                WriteLine(businessEntity1);
            }
            return _entitiesDummyList;
        }

        public BusinessEntity1 Get(int id)
        {
            WriteLine($"Return Item ID = {id}");
            return _entitiesDummyList.Single(x => x.Id == id);
        }

        public void Create(BusinessEntity1 item)
        {
            WriteLine("Item created");
            _entitiesDummyList.Add(item);
        }

        public void Update(BusinessEntity1 item)
        {
            WriteLine("Item updated");
            var value = _entitiesDummyList.Single(x => x.Id == item.Id);

            value.Name = item.Name;
        }

        public void Delete(int id)
        {
            WriteLine("Item deleted");
            var item = _entitiesDummyList.Single(x => x.Id == id);
            _entitiesDummyList.Remove(item);
        }

        public void Save()
        {
            //todo save context
        }
    }
}