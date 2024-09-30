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
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<ContactEntity> _repository;

        public UpdateContactCommandHandler(IRepository<ContactEntity> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);

            value.Name = command.Name;
            value.Email = command.Email;
            value.Message = command.Message;
            value.SendDate = command.SendDate;
            value.SendDate = command.SendDate;
            value.Subject = command.Subject;
            await _repository.UpdateAsync(value);
        }
    }
}
