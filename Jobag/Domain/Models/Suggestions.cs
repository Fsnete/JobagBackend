using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobag.Domain.Models
{
    public class Suggestions
    {
        public int Id { get; set; }

        public string Message { get; set; }

        User User { get; set; }

        public int User_Id { get; set; }

    }
}
