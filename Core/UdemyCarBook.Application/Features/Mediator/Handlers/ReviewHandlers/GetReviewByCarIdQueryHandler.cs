using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.ReviewQueries;
using UdemyCarBook.Application.Features.Mediator.Results.ReviewResults;
using UdemyCarBook.Application.Interfaces.ReviewInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReviewHandlers
{
    public class GetReviewByCarIdQueryHandler : IRequestHandler<GetReviewByCarIdQuery, List<GetReviewByCarIdQueryResult>>
    {
        private readonly IReviewRepository _repository;

        public GetReviewByCarIdQueryHandler(IReviewRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetReviewByCarIdQueryResult>> Handle(GetReviewByCarIdQuery request, CancellationToken cancellationToken)
        {
            var value =  _repository.GetReviewsByCarId(request.Id);
            return value.Select(x => new GetReviewByCarIdQueryResult
            {
                Id = x.Id,
                CustomerName = x.CustomerName,
                CustomerImage = x.CustomerImage,
                Comment = x.Comment,
                RaytingValue = x.RaytingValue,
                ReviewDate = x.ReviewDate,
                CarID = x.CarID
            }).ToList();
        }
    }
}
