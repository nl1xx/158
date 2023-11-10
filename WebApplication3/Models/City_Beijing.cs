using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class City_Beijing :CityPlaces
    {
        [Key]
        public int id
        {
            set;
            get;
        }
        public string commentsForBeijing
        {
            set;
            get;
        }
    }
}