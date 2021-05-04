using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobag.Domain.Models
{
    public class Postulant_Aplications
    {
        public int Id { get; set; }
        public bool Accepted { get; set; }

        public Job_Offer Job_Offer { get; set; }
    }
}
