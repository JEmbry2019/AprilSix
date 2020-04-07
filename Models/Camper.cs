using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CampAprilSix.Models
{
    public class Camper
    {
        public Guid ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime BirthDate { get; set;}
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}