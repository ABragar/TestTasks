using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task4.DB;
using Task4.Models;

namespace Task4.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        [HttpGet("search/{searchStr}")]
        public IEnumerable<BusinessEntity1> SampleData(string searchStr)
        {
            //emulation db-select
            return BusinessEntity1Db.EntitiesDummyList.Where(x => x.Name.Contains(searchStr));
        }

        [HttpPost("save")]
        public IActionResult Save([FromBody]BusinessEntity1 item)
        {
            //emulation db-save
            var value = BusinessEntity1Db.EntitiesDummyList.Single(x => x.Id == item.Id);
            value.Name = item.Name;
            value.Description = item.Description;
            return Ok();
        }
    }


}
