using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobag.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long Phone_Number { get; set; }
        public string Password { get; set; }
        public IList<Notification> Notifications { get; set; } = new List<Notification>();
        public Document Document { get; set; }
        public int Document_Id { get; set; }

    }
}
