using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobag.Domain.Models
{
    public class Job_Offer
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Employer Employer { get; set; }
        public int Employer_Id { get; set; }
        public string Begin_Date { get; set; }
        public string Final_Date { get; set; }
        public int Salary { get; set; }
    }
}
