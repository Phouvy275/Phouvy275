using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_MVC_CoRe.Models
{
    public class Student
    {
        public int ID { get; set; }
        public String Name{ get; set; }
        public DateTime Birthday { get; set; }
        public int Address_ID { get; set; }
        public String Address_Full { get; set; }

    }
}
