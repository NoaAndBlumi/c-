using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class MotherDto
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public long NumOfHouse { get; set; }
        public string Locality { get; set; }
        public System.DateTime BirthDate { get; set; }
        public int Active { get; set; }
        public user user { get; set; }
        public Birth birth { get; set; }
        public int NumOfChildren { get; set; }
       
        public string BoyOrGirl { get; set; }
        public int NumOfBabies { get; set; }

        public int BirthId { get; set; }
        public System.DateTime BirthDateOfBaby { get; set; }


    }
 
    public class motherDto
    {
 

        public Mother Mother { get; set; }
        public Users User { get; set; }

        public Kosher Kosher { get; set; }
        public Birth Birth { get; set; }
        public ServiceManagementToBirth ServiceManagementToBirth { get; set; }
        public Roles Roles { get; set; }

        //public long UserId { get; set; }
        //public int NumOfChildren { get; set; }
        //public long ServiceId { get; set; }
        //public long kosher1 { get; set; }
        //public long kosher2 { get; set; }
        //public long kosher3 { get; set; }



    }
}
