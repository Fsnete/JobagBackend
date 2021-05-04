using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobag.Domain.Models
{
    public class Postulant: User
    {
        public int postulant_id { get; set; }

        Profesional_Profile Profesional_profile { get; set; }

        public int Profesional_profile_id { get; set; }
    }
}
