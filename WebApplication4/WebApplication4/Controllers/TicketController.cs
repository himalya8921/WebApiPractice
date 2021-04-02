using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationBO;
using WebApplicationBO.Interface;
using WebApplicationEntities.Entities;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TicketController : ControllerBase
    {
        private readonly IWebApplicationBusinessAccess _ticketComponent;
        public TicketController(IWebApplicationBusinessAccess obj)
        {
            _ticketComponent = obj;
        }

        [HttpPost]
        public IActionResult CreateTicket(Ticket ticket)
        {
            _ticketComponent.InsertTicket(ticket);
            return Ok("Record inserted");
        }

        [HttpGet]
        [Authorize(Roles = "dev")]
        public IActionResult GetTicket()
        {
            var result = _ticketComponent.GetTickets();
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult DeleteTicket(long id)
        {
            var result = _ticketComponent.DeleteTicket(id);
            return Ok(result);
        }


    }
}
