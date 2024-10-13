using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commads.BlogCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHander : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<BlogEntity> _repository;

        public UpdateBlogCommandHander(IRepository<BlogEntity> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            value.Title = request.Title;
            value.Description = request.Description;
            value.CreatedDate = request.CreatedDate;
            value.CoverImageUrl = request.CoverImageUrl;
            value.AuthorID = request.AuthorID;
            value.CategoryID = request.CategoryID;
            await _repository.UpdateAsync(value);

        }
    }
}
