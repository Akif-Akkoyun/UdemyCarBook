using UdemyCarBook.Application.Features.CQRS.Results.ContactResult;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactQueryHandler
    {
        private readonly IRepository<ContactEntity> _repository;

        public GetContactQueryHandler(IRepository<ContactEntity> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetContactQueryResult>> Handle()
        {
            var values = await _repository.GetAllASync();
            return values.Select(x => new GetContactQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Message = x.Message,
                Subject = x.Subject,
                SendDate = x.SendDate
            }).ToList();
        }
    }
}
