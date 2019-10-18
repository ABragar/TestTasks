using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Task3.DAL.Entities;
using Task3.DAL.Interfaces;

namespace Task4.Controllers
{
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        private IUnitOfWork _uow;
        public ItemController(IUnitOfWork uow)
        {
            this._uow = uow;
        }
        [HttpGet("{searchStr}")]
        public IEnumerable<Item> Get(string searchStr)
        {
            return _uow.ItemRepository.GetAll().Where(x => x.Name.Contains(searchStr));
        }

        public IActionResult Post([FromBody]Item item)
        {
            //emulation db-save
            _uow.ItemRepository.Update(item);
            return Ok();
        }
    }


}
