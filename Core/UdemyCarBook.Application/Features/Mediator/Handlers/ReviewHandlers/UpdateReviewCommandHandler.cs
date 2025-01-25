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
    public class UpdateReviewCommandHandler : IRequestHandler<UpdateReviewCommand>
    {
        private readonly IRepository<ReviewEntity> _repository;

        public UpdateReviewCommandHandler(IRepository<ReviewEntity> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            value.CarID = request.CarID;
            value.Comment = request.Comment;
            value.CustomerImage = request.CustomerImage;
            value.CustomerName = request.CustomerName;
            value.RaytingValue = request.RaytingValue;
            value.ReviewDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            await _repository.UpdateAsync(value);
        }
    }
}
