using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commads.FeatureCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
    {
        private readonly IRepository<FeatureEntity> _repository;
        public UpdateFeatureCommandHandler(IRepository<FeatureEntity> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            values.Name = request.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
