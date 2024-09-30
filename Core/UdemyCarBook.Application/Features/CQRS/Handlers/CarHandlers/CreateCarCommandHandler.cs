using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.BrandCommands;
using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<CarEntity> _repository;

        public CreateCarCommandHandler(IRepository<CarEntity> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreatAsync(new CarEntity
            {
                Fuel = command.Fuel,
                BigImageUrl = command.BigImageUrl,
                Km = command.Km,
                Model = command.Model,
                Luggage = command.Luggage,
                Seat = command.Seat,
                BrandID = command.BrandID,
                CoverImageUrl = command.CoverImageUrl,
                Transmission = command.Transmission,
            });
        }
    }
}
