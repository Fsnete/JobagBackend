using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobag.Domain.Models
{
    public class Profesional_Profile
    {
        public int Id { get; set; }
        
        public string Description { get; set; }

        Ocupation Ocupation { get; set; }

        public int Ocupation_Id { get; set; }

        Languages Languages { get; set; }

        public int Languages_Id { get; set; }
        Studies Studies { get; set; }

        public int Studies_Id { get; set; }

        Video Video { get; set; }

        public int Video_Id { get; set; }

    }
}
