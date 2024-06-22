using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.WebShops;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace SecureShop.API
{
    public class WebShopsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<WebShop>>> GetWebshops()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WebShop>> GetWebshop(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateWebshop(WebShop webshop)
        {
            return Ok(await Mediator.Send(new Create.Command {WebShop = webshop}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditWebshop(Guid id, WebShop webshop)
        {
            webshop.Id = id;
            return Ok(await Mediator.Send(new Edit.Command{WebShop = webshop}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWebshop(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command {Id = id}));
        }
    }
}
