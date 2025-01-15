using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commads.CommentCommands;
using UdemyCarBook.Application.Features.Mediator.Commads.FeatureCommands;
using UdemyCarBook.Application.Features.Mediator.Commads.ServiceCommand;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class CreateCommentHandler : IRequestHandler<CreateCommentCommand>
    {
        private readonly IRepository<CommentEntity> _repository;

        public CreateCommentHandler(IRepository<CommentEntity> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreatAsync(new CommentEntity
            {
                Description= request.Description,
                Name = request.Name,
                BlogId = request.BlogID,
                CreatedAt = DateTime.Parse(DateTime.Now.ToShortDateString()),
                Email = request.Email
            });
        }
    }
}
