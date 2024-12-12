using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.StatisticsQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetCarCount")]
        public async Task<IActionResult> GetCarCount()
        {
            var values = await _mediator.Send(new GetCarCountQuery());
            return Ok(values);
        }
        [HttpGet("GetLocationCount")]
        public async Task<IActionResult> GetLocationCount()
        {
            var values = await _mediator.Send(new GetLocationCountQuery());
            return Ok(values);
        }

        [HttpGet("GetAuthorCount")]
        public async Task<IActionResult> GetAuthorCount()
        {
            var values = await _mediator.Send(new GetAuthorCountQuery());
            return Ok(values);
        }

        [HttpGet("GetBLogCount")]
        public async Task<IActionResult> GetBLogCount()
        {
            var values = await _mediator.Send(new GetBLogCountQuery());
            return Ok(values);
        }
        [HttpGet("GetBrandCount")]
        public async Task<IActionResult> GetBrandCount()
        {
            var values = await _mediator.Send(new GetBrandCountQuery());
            return Ok(values);
        }
        [HttpGet("GetAvgRentPriceForDayliy")]
        public async Task<IActionResult> GetAvgRentPriceForDayliy()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForDayliyQuery());
            return Ok(values);
        }
        [HttpGet("GetAvgRentPriceForWeekly")]
        public async Task<IActionResult> GetAvgRentPriceForWeekly()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForWeeklyQuery());
            return Ok(values);
        }
        [HttpGet("GetAvgRentPriceForMonthly")]
        public async Task<IActionResult> GetAvgRentPriceForMonthly()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForMonthlyQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountByTransmissionIsAuto")]
        public async Task<IActionResult> GetCarCountByTransmissionIsAuto()
        {
            var values = await _mediator.Send(new GetCarCountByTransmissionIsAutoQuery());
            return Ok(values);
        }
        [HttpGet("GetBrandNameByMaxCarCount")]
        public async Task<IActionResult> GetBrandNameByMaxCarCount()
        {
            var values = await _mediator.Send(new GetBrandNameByMaxCarCountQuery());
            return Ok(values);
        }
        [HttpGet("GetBlogTitleByMaxComments")]
        public async Task<IActionResult> GetBlogTitleByMaxComments()
        {
            var values = await _mediator.Send(new GetBlogTitleByMaxCommentsQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountByKmSmallerThan1000")]
        public async Task<IActionResult> GetCarCountByKmSmallerThan1000()
        {
            var values = await _mediator.Send(new GetCarCountByKmSmallerThan1000Query());
            return Ok(values);
        }
        [HttpGet("GetCarCountByFuelGasOrDiesel")]
        public async Task<IActionResult> GetCarCountByFuelGasOrDiesel()
        {
            var values = await _mediator.Send(new GetCarCountByFuelGasOrDieselQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountByFuelElectric")]
        public async Task<IActionResult> GetCarCountByFuelElectric()
        {
            var values = await _mediator.Send(new GetCarCountByFuelElectricQuery());
            return Ok(values);
        }
        [HttpGet("GetCarBrandAndModelByRendPriceDailyMax")]
        public async Task<IActionResult> GetCarBrandAndModelByRendPriceDailyMax()
        {
            var values = await _mediator.Send(new GetCarBrandAndModelByRendPriceDailyMaxQuery());
            return Ok(values);
        }
        [HttpGet("GetCarBrandAndModelByRendPriceDailyMin")]
        public async Task<IActionResult> GetCarBrandAndModelByRendPriceDailyMin()
        {
            var values = await _mediator.Send(new GetCarBrandAndModelByRendPriceDailyMinQuery());
            return Ok(values);
        }
    }
}
