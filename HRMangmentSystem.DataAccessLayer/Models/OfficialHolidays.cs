﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMangmentSystem.DataAccessLayer.Models
{
    public class OfficialHolidays
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "You must Enter The Holiday Name")]
        public string HolidayName { get; set; }
        public DateTime HolidayDate { get; set; }
    }
}
