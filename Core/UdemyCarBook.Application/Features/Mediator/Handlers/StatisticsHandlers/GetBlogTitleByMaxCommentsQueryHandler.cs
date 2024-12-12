using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.Mediator.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatistcsInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetBlogTitleByMaxCommentsQueryHandler : IRequestHandler<GetBlogTitleByMaxCommentsQuery, GetBlogTitleByMaxCommentsQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetBlogTitleByMaxCommentsQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetBlogTitleByMaxCommentsQueryResult> Handle(GetBlogTitleByMaxCommentsQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBlogTitleByMaxComments();
            return new GetBlogTitleByMaxCommentsQueryResult
            {
                BlogTitleByMaxComments = value
            };
        }
    }
}
