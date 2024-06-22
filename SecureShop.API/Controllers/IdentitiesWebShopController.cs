using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;


namespace SecureShop.API.Controllers
{
    public class IdentitiesWebShopController: BaseApiController
    {
        [HttpGet("{webShopId}")]
        public async Task<ActionResult<List<Identity>>> GetIdentities(Guid webShopId)
        {
            return await Mediator.Send(new List.Query { WebShopId = webShopId });
        }

        [HttpGet("{webShopId}/details")]
        public async Task<ActionResult<Identity>> GetIdentity(Guid webShopId)
        {
            return await Mediator.Send(new Details.Query { WebShopId = webShopId });
        }

        [HttpPost("{webShopId}")]
        public async Task<IActionResult> CreateIdentity(Guid webShopId, Identity identity)
        {
            identity.WebShopId = webShopId;
            return Ok(await Mediator.Send(new Create.Command { Identity = identity }));
        }

        [HttpPut("{webShopId}")]
        public async Task<IActionResult> EditIdentity(Guid webShopId, Identity identity)
        {
            identity.WebShopId = webShopId;
            return Ok(await Mediator.Send(new Edit.Command { Identity = identity }));
        }

        [HttpDelete("{webShopId}")]
        public async Task<IActionResult> DeleteIdentity(Guid webShopId)
        {
            return Ok(await Mediator.Send(new Delete.Command { WebShopId = webShopId }));
        }
    }
}

