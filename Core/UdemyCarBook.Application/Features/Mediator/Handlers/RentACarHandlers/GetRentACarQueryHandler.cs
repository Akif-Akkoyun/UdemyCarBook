using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.RentACarQueries;
using UdemyCarBook.Application.Features.Mediator.Results.PricingResult;
using UdemyCarBook.Application.Features.Mediator.Results.RentACarResult;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.RentACarInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;

        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsyc(x => x.LocationID == request.LocationID && x.Available == true);
            return values.Select(x => new GetRentACarQueryResult
            {
                Id = x.Id,
            }).ToList();
        }
    }
}
