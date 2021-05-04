using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobag.Domain.Models
{
    public class Notification
    {
        public int notification_id { get; set; }

        public string type { get; set; }

        public string description { get; set; }
    }
}
