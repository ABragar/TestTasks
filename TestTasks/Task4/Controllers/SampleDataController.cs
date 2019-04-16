using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task4.Models;

namespace Task4.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private List<BusinessEntity1> _entitiesDummyList = new List<BusinessEntity1>();

        public SampleDataController()
        {
            _entitiesDummyList.Add(new BusinessEntity1() { Id = 1, Name = "Entity1" });
            _entitiesDummyList.Add(new BusinessEntity1() { Id = 2, Name = "Entity2" });
            _entitiesDummyList.Add(new BusinessEntity1() { Id = 3, Name = "Entity3" });
            _entitiesDummyList.Add(new BusinessEntity1() { Id = 4, Name = "Entity4" });
            _entitiesDummyList.Add(new BusinessEntity1() { Id = 5, Name = "Entity5" });
        }


        [HttpGet("search/{searchStr}")]
        public IEnumerable<BusinessEntity1> SampleData(string searchStr)
        {
            return _entitiesDummyList.Where(x => x.Name.Contains(searchStr));
        }
    }


}
