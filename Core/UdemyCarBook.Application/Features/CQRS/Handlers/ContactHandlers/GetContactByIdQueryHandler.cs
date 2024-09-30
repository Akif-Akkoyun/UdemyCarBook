using UdemyCarBook.Application.Features.CQRS.Queries.ContactQueries;
using UdemyCarBook.Application.Features.CQRS.Results.ContactResult;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<ContactEntity> _repository;

        public GetContactByIdQueryHandler(IRepository<ContactEntity> repository)
        {
            _repository = repository;
        }
        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetContactByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Email = value.Email,
                Subject = value.Subject,
                Message = value.Message,
                SendDate = value.SendDate
            };
        }
    }
}
