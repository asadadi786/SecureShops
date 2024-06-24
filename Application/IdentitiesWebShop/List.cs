
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.IdentitiesWebShop
{
    public class List
    {
        public class Query : IRequest<List<IdentityWebShop>>
        {
            public Guid WebShopId { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<IdentityWebShop>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<IdentityWebShop>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Identities
                    .Where(i => i.WebShopId == request.WebShopId)
                    .ToListAsync();
            }
        }
    }
}
