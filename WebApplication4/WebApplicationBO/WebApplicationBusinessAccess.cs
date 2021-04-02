using System;
using System.Collections.Generic;
using WebApplicationBO.Interface;
using WebApplicationDO;
using WebApplicationDO.Interface;
using WebApplicationEntities.Entities;

namespace WebApplicationBO
{
    public class WebApplicationBusinessAccess : IWebApplicationBusinessAccess
    {

        private readonly IWebApplicationDataAccess _ticketData;

        public WebApplicationBusinessAccess(IWebApplicationDataAccess obj)
        {
            _ticketData = obj;
        }

        public int DeleteTicket(long ticketId)
        {
            return _ticketData.DeleteTicket(ticketId);
        }

        public List<Ticket> GetTickets()
        {
            return _ticketData.GetTickets();
        }

        public Ticket GetTicketById(long ticketId)
        {
            throw new NotImplementedException();
        }

        public int InsertTicket(Ticket ticket)
        {
            return _ticketData.InsertTicket(ticket);
            throw new NotImplementedException();
        }

        public int UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            return _ticketData.GetUsers();
        }
    }
}
