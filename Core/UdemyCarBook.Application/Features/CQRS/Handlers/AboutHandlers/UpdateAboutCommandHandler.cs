using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<AboutEntity> _repository;

        public UpdateAboutCommandHandler(IRepository<AboutEntity> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAboutCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            value.Title = command.Title;
            value.Description = command.Description;
            value.ImageUrl = command.ImageUrl;
            await _repository.UpdateAsync(value);
        }
    }
}
