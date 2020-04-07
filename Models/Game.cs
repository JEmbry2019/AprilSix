using System;
using System.Collections.Generic;

namespace CampAprilSix.Models
{
    public class Game
    {
        public Guid ID { get; set; }
        public string SportA { get; set; }
        public int SportB { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}