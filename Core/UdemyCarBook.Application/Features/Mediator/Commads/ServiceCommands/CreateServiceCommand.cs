using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commads.ServiceCommand
{
    public class CreateServiceCommand : IRequest
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string IconUrl { get; set; } = default!;
    }
}
