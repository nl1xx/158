﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class PersonalComments
    {
        [Key]
        public string personalComment
        {
            set;
            get;
        }

    }
}