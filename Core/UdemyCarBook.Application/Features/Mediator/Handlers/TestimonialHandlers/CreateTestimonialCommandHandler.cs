using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commads.TestimonialCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler :IRequestHandler<CreateTestimonialCommand>
    {
        private readonly IRepository<TestimonialEntity> _repository;

        public CreateTestimonialCommandHandler(IRepository<TestimonialEntity> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreatAsync(new TestimonialEntity
            {
                Name = request.Name,
                Comment = request.Comment,
                Title = request.Title,
                ImageUrl = request.ImageUrl
            });
        }
    }
}
