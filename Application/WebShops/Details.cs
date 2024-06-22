using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.WebShops
{
    public class Details
    {
           public class Query : IRequest<WebShop>
           {
                public Guid Id {get; set;}
           }

        public class Handler : IRequestHandler<Query, WebShop>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<WebShop> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.WebShops.FindAsync(request.Id);
            }
        }

    }
}