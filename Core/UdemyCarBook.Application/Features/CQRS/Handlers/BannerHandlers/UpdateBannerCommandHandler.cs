using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<BannerEntity> _repository;

        public UpdateBannerCommandHandler(IRepository<BannerEntity> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBannerCommand banner)
        {
            var value = await _repository.GetByIdAsync(banner.Id);

            value.Title = banner.Title;
            value.Description = banner.Description;
            value.VideoUrl = banner.VideoUrl;
            value.VideoDescription = banner.VideoDescription;
            await _repository.UpdateAsync(value);
        }
    }
}
