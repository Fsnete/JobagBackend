using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobag.Domain.Models
{
    public class Interview
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public Employer Employer { get; set; }

        public int Employer_Id { get; set; }

        public Postulant Postulant{ get; set; }

        public int Postulant_Id { get; set; }

        public int Hour { get; set; }

        public string Link { get; set; }

        public string Final_Date { get; set; }

        public Job_Offer Job_Offer { get; set; }
        public int Job_Offer_Id { get; set; }

    }
}
