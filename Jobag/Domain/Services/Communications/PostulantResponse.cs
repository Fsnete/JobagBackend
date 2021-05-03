using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jobag.Domain.Models;

namespace Jobag.Domain.Services.Communications
{
    public class PostulantResponse: BaseResponse<Postulant>
    {
        public PostulantResponse(Postulant resource) : base(resource)
        {
        }

        public PostulantResponse(string message) : base(message)
        {
        }
    }
}
