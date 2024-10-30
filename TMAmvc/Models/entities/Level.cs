using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMAmvc.Models.enums;

namespace TMAmvc.Models.entities
{
    public class Level
    {
        public List<Tutee> ListOfTutee {get; set;}
        public List<Subject> ListOfSubject {get; set;}
    }
}