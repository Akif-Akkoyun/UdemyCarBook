﻿using MediatR;
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
    public class GetBrandNameByMaxCarCountQueryHandler : IRequestHandler<GetBrandNameByMaxCarCountQuery, GetBrandNameByMaxCarCountQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetBrandNameByMaxCarCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetBrandNameByMaxCarCountQueryResult> Handle(GetBrandNameByMaxCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBrandNameByMaxCarCount();
            return new GetBrandNameByMaxCarCountQueryResult
            {
                BrandNameByMaxCarCount = value
            };
        }
    }
}
