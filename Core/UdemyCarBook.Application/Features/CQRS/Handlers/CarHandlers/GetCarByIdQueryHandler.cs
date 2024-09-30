using UdemyCarBook.Application.Features.CQRS.Queries.CarQueries;
using UdemyCarBook.Application.Features.CQRS.Results.BrandResults;
using UdemyCarBook.Application.Features.CQRS.Results.CarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<CarEntity> _repository;

        public GetCarByIdQueryHandler(IRepository<CarEntity> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                Id = value.Id,
                BrandID = value.BrandID,
                Model = value.Model,
                Transmission = value.Transmission,
                Seat = value.Seat,
                Luggage = value.Luggage,
                Km = value.Km,
                BigImageUrl = value.BigImageUrl,
                CoverImageUrl = value.CoverImageUrl,
                Fuel = value.Fuel
            };
        }
    }
}
