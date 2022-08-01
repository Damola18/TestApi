using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        [Route("api/projects")]
        public IActionResult Get()
        {
            return Ok("Reading all the projects");
        }

        [HttpGet]
        [Route("api/projects/{id}")]

        public IActionResult GetBy(int id)
        {
            return Ok($"Reading project #{id}.");

        }

        /// <summary>
        /// api/projects/{pid}/tickets?tid={tid
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjectTicket(int pId, [FromQuery] int tId)
        {
            if (tId == 0)
                return Ok($"Reading all the tickets belonging to project #{pId}");
            else
                return Ok($"Reading Projects #{pId}, ticket #{tId}");

        }

        /* [HttpGet]
         [Route("/api/projects/{pid}/tickets")]
         public IActionResult GetProjectTicket( [FromQuery] Ticket ticket)
         {
             if (ticket == null) return BadRequest("Wrong parameters");

             if ( ticket.TicketId == 0)
                 return Ok($"Reading all the tickets belonging to project #{ticket.ProjectId}");
             else
                 return Ok($"Reading Projects #{ticket.ProjectId}, ticket #{ticket.TicketId}, title: {ticket.Title}, Description: {ticket.Description}");

         }
         */

        [HttpPost]
        [Route("api/projects")]
        public IActionResult Post()
        {
            return Ok("Creating a project");
        }

        [HttpPut]
        [Route("api/projects")]
        public IActionResult Put()
        {
            return Ok("Updating a project");
        }

        [HttpDelete("{id}")]
        [Route("api/projects/{id}")]

        public IActionResult Delete(int id)
        {
            return Ok($"Deleting project #{id}. ");
        }
    }
}
