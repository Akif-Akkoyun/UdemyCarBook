using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<BlogEntity> _repository;

        public GetBlogByIdQueryHandler(IRepository<BlogEntity> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdQueryResult
            {
                Id = values.Id,
                Title = values.Title,
                Description = values.Description,
                AuthorID = values.AuthorID,
                CategoryID = values.CategoryID,
                CoverImageUrl = values.CoverImageUrl,
                CreatedDate = values.CreatedDate,
            };
        }
    }
}
