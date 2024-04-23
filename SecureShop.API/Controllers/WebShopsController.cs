using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace SecureShop.API
{
    public class WebShopsController : BaseApiController
    {
        private readonly DataContext _context;
        public WebShopsController(DataContext context)
        {
            _context = context;
        }

    [HttpGet]
    public async Task<ActionResult<List<WebShop>>> GetWebshops()
    {
        return await _context.WebShops.ToListAsync();        
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<WebShop>> GetWebshop(Guid id)
    {
        return await _context.WebShops.FindAsync(id);
    }
    }
}
