using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplicationEntities.Entities
{
    public partial class Designation
    {
        public Designation()
        {
            Employee = new HashSet<Employee>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
