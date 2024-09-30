using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.CategoryCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly IRepository<CategoryEntity> _repository;

        public CreateCategoryCommandHandler(IRepository<CategoryEntity> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCategoryCommand command)
        {
            await _repository.CreatAsync(new CategoryEntity
            {
                Name = command.Name,
            });
        }
    }
}
