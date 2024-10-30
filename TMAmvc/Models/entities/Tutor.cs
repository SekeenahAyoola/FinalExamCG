using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMAmvc.Models.enums;

namespace TMAmvc.Models.entities
{
    public class Tutor : BaseEntity
    {
        public string UserId {get;}
        public TutorRating Tutor_Rating {get; set;}
        public string CVImagePath {get; set;}
        public bool HasTutee {get; set;}
    }
}