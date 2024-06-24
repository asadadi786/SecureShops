using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.IdentitiesWebShop
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid WebShopId { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var identity = await _context.Identities
                    .FindAsync(request.WebShopId);
//                    .FirstOrDefaultAsync(i => i.WebShopId == request.WebShopId);
                if (identity == null)
                {
                    // Handle not found
                }

                _context.Identities.Remove(identity);
                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
