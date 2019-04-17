using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task3.DAL.Entities;
using Task3.DAL.Interfaces;

namespace Task4.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private IUnitOfWork _uow;
        public SampleDataController(IUnitOfWork uow)
        {
            this._uow = uow;
        }
        [HttpGet("search/{searchStr}")]
        public IEnumerable<BusinessEntity1> SampleData(string searchStr)
        {
            return _uow.BusinessEntities1Repo.GetAll().Where(x => x.Name.Contains(searchStr));
        }

        [HttpPost("save")]
        public IActionResult Save([FromBody]BusinessEntity1 item)
        {
            //emulation db-save
            _uow.BusinessEntities1Repo.Update(item);
            return Ok();
        }
    }


}
