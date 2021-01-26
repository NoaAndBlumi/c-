using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace Dto
{
   public class BirthDto
    {
        public Birth birth { get; set; }
        public long BirthId { get; set; }
        public long UserId { get; set; }
        public string BoyOrGirl { get; set; }
        public int NumOfBabies { get; set; }
        public System.DateTime BirthDateOfBaby { get; set; }

    }
}
