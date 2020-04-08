using System.Collections.Generic;
using System.Threading.Tasks;
using CleanBackend.Application.Commands;
using CleanBackend.Application.Models;
using CleanBackend.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CleanBackend.API.Controllers
{
    public class ItemsController : ApiController
    {
        [HttpGet("{id}", Name = "GetItem")]
        public async Task<ActionResult<ItemModel>> GetItem(string id)
        {
            var item = await Mediator.Send(new GetItemQuery { ItemId = id });

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemModel>>> GetItems()
        {
            var result = await Mediator.Send(new GetItemsQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ItemModel>> CreateItem([FromBody] CreateItemCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
