
using System.Collections.Generic;
using WebApplicationEntities.Entities;
//using WebApplication4.Models;

namespace WebApplicationBO.Interface
{
   public  interface IWebApplicationBusinessAccess
    {

        public int InsertTicket(Ticket ticket);

        public List<Ticket> GetTickets();

        public int DeleteTicket(long ticketId);

        public int UpdateTicket(Ticket ticket);

        public List<User> GetUsers();
    }
}
