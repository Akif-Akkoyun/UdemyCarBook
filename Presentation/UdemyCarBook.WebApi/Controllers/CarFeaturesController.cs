using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commads.CarFeatureCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries;
using UdemyCarBook.Application.Features.Mediator.Queries.CarFeatureQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarFeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CarFeatureListByCarId(int id)
        {
            var result = await _mediator.Send(new GetCarFeatureByCarIdQuery(id));
            return Ok(result);
        }
        [HttpGet("ChangeCarFeatureAvailableToFalse")]
        public async Task<IActionResult> ChangeCarFeatureAvailableToFalse(int id)
        {
            await _mediator.Send(new UpdateCarFeatureAvaliableChangeToFalseCommand(id));
            return Ok("Güncelleme Yapıldı");
        }
    }
}
