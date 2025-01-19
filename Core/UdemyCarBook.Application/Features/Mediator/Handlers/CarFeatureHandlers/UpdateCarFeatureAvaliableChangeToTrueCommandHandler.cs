using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commads.CarFeatureCommands;
using UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class UpdateCarFeatureAvaliableChangeToTrueCommandHandler : IRequestHandler<UpdateCarFeatureAvaliableChangeToTrueCommand>
    {
        private readonly ICarFeatureRepository _repository;

        public UpdateCarFeatureAvaliableChangeToTrueCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCarFeatureAvaliableChangeToTrueCommand request, CancellationToken cancellationToken)
        {
             _repository.ChangeCarFeatureAvailableToTrue(request.Id);
        }
    }
}
