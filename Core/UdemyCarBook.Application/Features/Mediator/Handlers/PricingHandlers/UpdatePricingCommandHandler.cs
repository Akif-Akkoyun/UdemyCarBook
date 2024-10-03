using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commads.PricingCommand;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommand>
    {
        private readonly IRepository<PricingEntity> _repository;

        public UpdatePricingCommandHandler(IRepository<PricingEntity> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
        }
    }
}
