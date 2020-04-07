using CampAprilSix.Models;
using Microsoft.EntityFrameworkCore;

namespace CampAprilSix.Data
{
    //Creates a new database context named StudentInformationContext
    public class CampAprilSixContext : DbContext
    {
        public CampAprilSixContext(DbContextOptions<CampAprilSixContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Game> Games { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Camper> Campers { get; set; }
        public DbSet<Meal> Meals { get; set; }
    }
}