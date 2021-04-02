using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplicationEntities.Entities
{
    public partial class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
        public long CourseId { get; set; }
        public int Age { get; set; }
        public long Fees { get; set; }
        public long AdmissionNo { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? UpdateBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Course Course { get; set; }
    }
}
