using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commads.ReservationCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class ReservationCommandHandlers : IRequestHandler<CreateReservationCommand>
    {
        private readonly IRepository<ReservationEntity> _repository;

        public ReservationCommandHandlers(IRepository<ReservationEntity> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreatAsync(new ReservationEntity
            {
                Age = request.Age,
                CarID = request.CarID,
                Description = request.Description,
                DrivingLicence = request.DrivingLicence,
                Email = request.Email,
                Name = request.Name,
                Phone = request.Phone,
                Surname = request.Surname,
                PickUpLocationID = request.PickUpLocationID,
                DropOffLocationID = request.DropOffLocationID
            });
        }
    }
}
