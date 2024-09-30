
using UdemyCarBook.Application.Features.CQRS.Results.BannerResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<BannerEntity> _repository;

        public GetBannerQueryHandler(IRepository<BannerEntity> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var values = await _repository.GetAllASync();
            return values.Select(x => new GetBannerQueryResult
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                VideoDescription = x.VideoDescription,
                VideoUrl = x.VideoUrl
            }).ToList();
        }
    }
}
