using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using UdemyCarBook.Application.Features.Mediator.Commads.ReviewCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.LocationQueries;
using UdemyCarBook.Application.Features.Mediator.Queries.ReviewQueries;
using UdemyCarBook.Application.Validators.ReviewValidators;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReviewsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ReviewListByCarId(int id)
        {
            var result = await _mediator.Send(new GetReviewByCarIdQuery(id));
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateReview(CreateReviewCommand command)
        {
            CreateReviewValidator validator = new CreateReviewValidator();
            var validationResult = await validator.ValidateAsync(command);

            if (!ModelState.IsValid)
            {
                await _mediator.Send(command);
                return Ok("Ekleme işlemi gerçekleşti.");
            }
           return BadRequest(validationResult.Errors);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReview(UpdateReviewCommand command)
        {
            await _mediator.Send(command);
            return Ok("Güncelleme işlemi gerçekleşti.");
        }
    }
}
