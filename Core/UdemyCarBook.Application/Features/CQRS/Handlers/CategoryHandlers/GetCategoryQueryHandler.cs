using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Results.BrandResults;
using UdemyCarBook.Application.Features.CQRS.Results.CategoryResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<CategoryEntity> _repository;

        public GetCategoryQueryHandler(IRepository<CategoryEntity> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _repository.GetAllASync();
            return values.Select(x => new GetCategoryQueryResult
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}
