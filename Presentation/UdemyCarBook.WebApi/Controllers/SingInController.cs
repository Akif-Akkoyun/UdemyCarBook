using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.AppUserQueries;
using UdemyCarBook.Application.Tools;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingInController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SingInController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(GetCheckAppUserQuery query)
        {
            var result = await _mediator.Send(query);
            if(result.IsExist)
            {
                return Created("",JwtTokenGenerator.GenerateToken(result));
            }
            else
            {
                return BadRequest("Kullanıcı adı veya şifre hatalı");
            }
        }
    }
}
