using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMAmvc.Models.entities
{
    public class Admin : BaseEntity
    {
        public string UserId {get;}
        public string AdminId {get; set;} = Guid.NewGuid().ToString();
    }
}