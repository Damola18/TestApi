using Cores.Models;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all the tickets");
        }

        [HttpGet("{id}")]
        public IActionResult GetBy(int id)
        {
            return Ok($"Reading ticket #{id}. ");
        }

        [HttpPost]
        public IActionResult Post ([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting a ticket #{id}.");
        }
    }
}
