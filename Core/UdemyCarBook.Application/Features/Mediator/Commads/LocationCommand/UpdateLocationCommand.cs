using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Commads.LocationCommand
{
    internal class UpdateLocationCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
