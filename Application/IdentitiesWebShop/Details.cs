using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.IdentitiesWebShop
{
    public class Details
    {
        public class Query : IRequest<IdentityWebShop>
        {
            public Guid WebShopId { get; set; }
        }

        public class Handler : IRequestHandler<Query, IdentityWebShop>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<IdentityWebShop> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Identities
                    .FindAsync(request.WebShopId);

            }
        }
    }
}
