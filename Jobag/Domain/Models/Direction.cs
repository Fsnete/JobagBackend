using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobag.Domain.Models
{
    public class Direction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number{ get; set; }
        public string References { get; set; }
        public string City_Name { get; set; }
        public string District_Name { get; set; }
    }
}
