using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplicationEntities.Entities
{
    public partial class Ticket
    {
        public long TicketId { get; set; }
        public long UserId { get; set; }
        public string TicketSubject { get; set; }
        public bool? IsActive { get; set; }
    }
}
