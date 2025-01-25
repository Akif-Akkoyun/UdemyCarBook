using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commads.PricingCommand;
using UdemyCarBook.Application.Features.Mediator.Commads.ReviewCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReviewHandlers
{
    public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand>
    {
        private readonly IRepository<ReviewEntity> _repository;

        public CreateReviewCommandHandler(IRepository<ReviewEntity> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreatAsync(new ReviewEntity
            {
                CarID = request.CarID,
                Comment = request.Comment,
                CustomerImage = request.CustomerImage,
                CustomerName = request.CustomerName,
                RaytingValue = request.RaytingValue,
                ReviewDate = DateTime.Parse(DateTime.Now.ToShortDateString())
            });
        }
    }
}
