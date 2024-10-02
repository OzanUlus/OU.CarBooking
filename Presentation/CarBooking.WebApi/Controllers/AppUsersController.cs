using CarBooking.Application.Features.CQRS.Commands.AppUserCommand;
using CarBooking.Application.Features.CQRS.Queries.AppUserQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppUsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(CreateAppUserCommandRequest request)
        {
            var result = await _mediator.Send(request);
            if (result.Succeeded)
            {
                return Ok("User registered successfully.");
            }

            return BadRequest(result.Errors);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginCommandRequest request)
        {
            var result = await _mediator.Send(request);
            if (result==null)
            {
                return BadRequest("Email or password wrong");
            }

            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser(UpdateAppUserCommandRequest request )
        {
            var result = await _mediator.Send(request);
            if (result.Succeeded)
            {
                return Ok("User updated successfully.");
            }

            return BadRequest(result.Errors);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            
            var result = await _mediator.Send(new DeleteAppUserCommandRequest(userId));

            if (result.Succeeded)
            {
                return Ok("User deleted successfully.");
            }

            return BadRequest(result.Errors);
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            
            var users = await _mediator.Send(new GetAllAppUsersQueryRequest());

            return Ok(users);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser(int userId)
        {

            var users = await _mediator.Send(new GetAppUserQueryRequest(userId));

            return Ok(users);
        }

    }
}
