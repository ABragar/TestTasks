using System.Collections.Generic;
using System.Linq;
using Task3.DAL.Entities;

namespace Task3.DAL.DB
{
    public static class Database
    {
        public static List<Item> EntitiesDummyList = new List<Item>();

        static Database()
        {
            //init sample db
            if (!EntitiesDummyList.Any())
            {
                EntitiesDummyList.Add(new Item() { Id = 1, Name = "Entity1" });
                EntitiesDummyList.Add(new Item() { Id = 2, Name = "Entity2" });
                EntitiesDummyList.Add(new Item() { Id = 3, Name = "Entity3" });
                EntitiesDummyList.Add(new Item() { Id = 4, Name = "Entity4" });
                EntitiesDummyList.Add(new Item() { Id = 5, Name = "Entity5" });
            }
        }
    }
}
