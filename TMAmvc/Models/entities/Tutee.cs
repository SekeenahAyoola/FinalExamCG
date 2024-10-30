using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMAmvc.Models.enums;

namespace TMAmvc.Models.entities
{
    public class Tutee
    {
        public string UserId {get;}
        public TuteeLevel Tutee_Level {get; set;}
        public bool HasTutor {get; set;}
        public List<Subject> ListOfSubject {get; set;}
        
    }
}