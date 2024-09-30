using UdemyCarBook.Application.Features.CQRS.Results.BrandResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<BrandEntity> _repository;

        public GetBrandQueryHandler(IRepository<BrandEntity> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetBrandQueryResult>> Handle()
        {
            var values = await _repository.GetAllASync();
            return values.Select(x => new GetBrandQueryResult
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}
