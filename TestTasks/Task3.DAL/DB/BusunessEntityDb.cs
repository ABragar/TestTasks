using System.Collections.Generic;
using System.Linq;
using Task3.DAL.Entities;

namespace Task3.DAL.DB
{
    public static class BusunessEntityDb
    {
        public static List<BusinessEntity1> EntitiesDummyList = new List<BusinessEntity1>();

        static BusunessEntityDb()
        {
            //init sample db
            if (!EntitiesDummyList.Any())
            {
                EntitiesDummyList.Add(new BusinessEntity1() { Id = 1, Name = "Entity1" });
                EntitiesDummyList.Add(new BusinessEntity1() { Id = 2, Name = "Entity2" });
                EntitiesDummyList.Add(new BusinessEntity1() { Id = 3, Name = "Entity3" });
                EntitiesDummyList.Add(new BusinessEntity1() { Id = 4, Name = "Entity4" });
                EntitiesDummyList.Add(new BusinessEntity1() { Id = 5, Name = "Entity5" });
            }
        }
    }
}
