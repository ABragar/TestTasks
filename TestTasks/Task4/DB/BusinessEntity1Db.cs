using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task4.Models;

namespace Task4.DB
{
    public static class BusinessEntity1Db
    {
        public static List<BusinessEntity1> EntitiesDummyList = new List<BusinessEntity1>();
        static BusinessEntity1Db()
        {
            EntitiesDummyList.Add(new BusinessEntity1() { Id = 1, Name = "Entity1" });
            EntitiesDummyList.Add(new BusinessEntity1() { Id = 2, Name = "Entity2" });
            EntitiesDummyList.Add(new BusinessEntity1() { Id = 3, Name = "Entity3" });
            EntitiesDummyList.Add(new BusinessEntity1() { Id = 4, Name = "Entity4" });
            EntitiesDummyList.Add(new BusinessEntity1() { Id = 5, Name = "Entity5" });
        }
    }
}
