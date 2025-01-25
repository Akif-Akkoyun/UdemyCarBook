using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Enums;
using UdemyCarBook.Application.Features.Mediator.Commads.RegisterCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
    {
        private readonly IRepository<AppUserEntity> _repository;

        public CreateAppUserCommandHandler(IRepository<AppUserEntity> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreatAsync(new AppUserEntity
            {
                UserName = request.UserName,
                Password = request.Password,
                AppRoleId = (int)Rolestype.Member,
                Mail = request.Mail,
                Name = request.Name,
                Surname = request.Surname
            });

        }
    }
}
