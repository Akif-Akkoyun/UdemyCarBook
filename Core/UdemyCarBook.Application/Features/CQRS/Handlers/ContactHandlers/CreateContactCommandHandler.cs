using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.ContactCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler
    {
        private readonly IRepository<ContactEntity> _repository;

        public CreateContactCommandHandler(IRepository<ContactEntity> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateContactCommand command)
        {
            await _repository.CreatAsync(new ContactEntity
            {
                Name = command.Name,
                Email = command.Email,
                SendDate = command.SendDate,
                Message = command.Message,
                Subject = command.Subject,
            });
        }
    }
}
