using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.WebShops
{
    public class List
    {
        public class Query : IRequest<List<WebShop>>{}

        public class Handler : IRequestHandler<Query, List<WebShop>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context) 
            {
                _context = context;
            }

            public async Task<List<WebShop>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.WebShops.ToListAsync();
            }
        }
    }
}