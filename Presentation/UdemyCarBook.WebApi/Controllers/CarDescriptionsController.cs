using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;
using UdemyCarBook.Application.Features.Mediator.Queries.LocationQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDescriptionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarDescriptionsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("CarDescriptionByCarId/{id}")]
        public async Task<IActionResult> CarDescriptionByCarID(int id)
        {
            var result = await _mediator.Send(new GetCarDescriptionByCarIdQuery(id));
            if (result == null)
            {
                throw new InvalidOperationException("Bu 'ID' ye ait veri bulunamadı.");
            }
            return Ok(result);
        }
    }
}
