using System;

namespace CampAprilSix.Models
{
    public enum Food
    {
        Meat, Veg, Snack
    }
    public class Meal
    {
        public Guid ID { get; set; }
       
        public string Breakfast { get; set; }
        public string Lunch { get; set; }
        public Food Type { get; set;}

    }
}