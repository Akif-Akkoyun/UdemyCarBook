using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<CarEntity> _repository;

        public UpdateCarCommandHandler(IRepository<CarEntity> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            value.Transmission = command.Transmission;
            value.Model = command.Model;
            value.BrandID = command.BrandID;
            value.BigImageUrl = command.BigImageUrl;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Km = command.Km;
            value.Seat = command.Seat;
            value.Luggage = command.Luggage;
            value.Fuel = command.Fuel;
            await _repository.UpdateAsync(value);
        }
    }
}
