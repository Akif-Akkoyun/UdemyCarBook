using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogIdQuery : IRequest<GetBlogByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBlogIdQuery(int id)
        {
            Id = id;
        }
    }
}
