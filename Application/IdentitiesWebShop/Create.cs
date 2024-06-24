using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.IdentitiesWebShop
{
    public class Create
    {
        public class Command : IRequest
        {
            public IdentityWebShop Identity { get; set; }
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
                // Check if the WebShop exists
                var webShop = await _context.WebShops.FindAsync(request.Identity.WebShopId);
                if (webShop == null)
                {
                    // Handle not found (you might want to throw an exception or handle this case differently)
                }

                _context.Identities.Add(request.Identity);
                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
