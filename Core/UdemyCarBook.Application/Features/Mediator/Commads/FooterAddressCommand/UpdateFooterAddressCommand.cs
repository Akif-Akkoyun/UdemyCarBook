using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Commads.FooterAddressCommand
{
    public class UpdateFooterAddressCommand : IRequest
    {
        public int Id { get; set; }
        public string Description { get; set; } = default!;
        public string Adress { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Email { get; set; } = default!;
    }
}
