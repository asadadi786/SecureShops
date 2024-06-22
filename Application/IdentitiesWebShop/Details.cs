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
        public class Query : IRequest<Identity>
        {
            public Guid WebShopId { get; set; }
        }

        public class Handler : IRequestHandler<Query, Identity>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Identity> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Identities
                    .FirstOrDefaultAsync(i => i.WebShopId == request.WebShopId);
            }
        }
    }
}
