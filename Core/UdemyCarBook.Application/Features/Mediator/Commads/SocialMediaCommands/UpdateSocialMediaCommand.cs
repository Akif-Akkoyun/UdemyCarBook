using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UdemyCarBook.Application.Features.Mediator.Commads.SocialMediaCommands
{
    public class UpdateSocialMediaCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Icon { get; set; } = default!;
        public string Url { get; set; } = default!;
    }
}
