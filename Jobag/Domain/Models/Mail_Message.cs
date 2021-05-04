using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobag.Domain.Models
{
    public class Mail_Message
    {
        public int Id { get; set; }
        Postulant Postulant { get; set; }
        public int Postulant_Id { get; set; }
        public string Message { get; set; }
        public string Document_Link { get; set; }
        Employer Employer { get; set; }
        public int Employer_Id { get; set; }
    }
}
