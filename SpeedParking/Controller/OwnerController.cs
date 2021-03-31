using MediatR;
using Microsoft.AspNetCore.Mvc;
using SpeedParking.Application.Command;
using SpeedParking.Application.Request;
using System.Threading.Tasks;

namespace SpeedParking.Api.Controller
{
    [Route("api/[controller]")]
    public class OwnerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OwnerController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("name")]
        public async Task<IActionResult> GetOwner()
        {
            var command = new GetOwnerRequest();

            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddOnwerAsync(AddOwnerCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }
    }
}