using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class City_NewZealand : CityPlaces
    {
        [Key]
        public int id
        {
            set;
            get;
        }
        public string commentsForNewZealand
        {
            set;
            get;
        }
    }
}