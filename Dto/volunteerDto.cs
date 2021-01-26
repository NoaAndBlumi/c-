﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class volunteerDto
    {
        public long RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public long NumOfHouse { get; set; }
        public string Locality { get; set; }
        public System.DateTime BirthDate { get; set; }
        public int Active { get; set; }



        public user MyUser { get; set; }
        public long UserId { get; set; }

        //DayToVolunteer
        public int DayId { get; set; }
        public System.TimeSpan BeginningTime { get; set; }
        public System.TimeSpan EndTime { get; set; }

        //ServiceToVolunteer
        public long ServiseId { get; set; }
        //services
        public string Describe { get; set; }
    }
}
