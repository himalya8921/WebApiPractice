using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationEntities.Entities;

namespace WebApplicationDO.Interface
{
    public interface IWebApplicationDataAccess
    {
      
        public int InsertTicket(Ticket ticket);

        public List<Ticket> GetTickets();
        public int DeleteTicket(long ticketId);

        public int UpdateTicket(Ticket ticket);

        public List<User> GetUsers();

    }
}
