
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.IdentitiesWebShop
{
    public class Edit
    {
        public class Command : IRequest
        {
            public IdentityWebShop Identity { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var identity = await _context.Identities
                    .FirstOrDefaultAsync(i => i.WebShopId == request.Identity.WebShopId);

                if (identity == null)
                {
                    // Handle not found
                }

                _mapper.Map(request.Identity, identity);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
