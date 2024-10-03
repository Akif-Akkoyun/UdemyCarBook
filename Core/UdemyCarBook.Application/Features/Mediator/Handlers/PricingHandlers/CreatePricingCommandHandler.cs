using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commads.PricingCommand;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreatPricingCommand>
    {
        private readonly IRepository<PricingEntity> _repository;

        public CreatePricingCommandHandler(IRepository<PricingEntity> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreatPricingCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreatAsync(new PricingEntity
            {
                Name = request.Name
            });
        }
    }
}
