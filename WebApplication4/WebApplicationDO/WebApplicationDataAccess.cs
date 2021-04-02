using System;
using System.Collections.Generic;
using System.Linq;
using WebApplicationDO.Interface;
using WebApplicationEntities.Entities;

namespace WebApplicationDO
{
    public class WebApplicationDataAccess : IWebApplicationDataAccess
    {

        private readonly EmployeeDbContext _ticketDbContext;

        public WebApplicationDataAccess(EmployeeDbContext obj)
        {
            _ticketDbContext = obj;
        }
        public int DeleteTicket(long ticketId)
        {

            var Obj = _ticketDbContext.Ticket.FirstOrDefault(x => x.TicketId == ticketId);
            if (Obj != null)
            {
                _ticketDbContext.Ticket.Remove(Obj);
                _ticketDbContext.SaveChanges();
            }
            return 1;
        }

        public List<Ticket> GetTickets()
        {
            return _ticketDbContext.Ticket.ToList();

        }

        public List<User> GetUsers()
        {
            return _ticketDbContext.User.ToList();
        }

        public int InsertTicket(Ticket ticket)
        {
            _ticketDbContext.Ticket.Add(ticket);
            return _ticketDbContext.SaveChanges();
        }

        public int UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

    
    }
}
