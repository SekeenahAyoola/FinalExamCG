using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMAmvc.Models.entities
{
    public class Rating : BaseEntity
    {
        public Tutor Tutor {get; set;}
    }
}