using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commads.PricingCommand;
using UdemyCarBook.Application.Features.Mediator.Queries.PricingQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> PricingList()
        {
            var result = await _mediator.Send(new GetPricingQuery());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPricing(int id)
        {
            var result = await _mediator.Send(new GetPricingByIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePricing(CreatPricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ödeme Türü başarıyla eklendi.");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePricing(int id)
        {
            await _mediator.Send(new RemovePricingCommand(id));
            return Ok("Ödeme Türü başarıyla silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ödeme Türü başarıyla güncellendi.");
        }
    }
}
