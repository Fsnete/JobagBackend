using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobag.Domain.Models
{
    public class Company_Profile
    {
        public int Id { get; set; }
        public string Business_Name { get; set; }
        public string Description { get; set; }
        public int RUC { get; set; }

        Business_Sector Sector { get; set; }
        Direction Direction { get; set; }

    }
}
