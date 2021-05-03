using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jobag.Domain.Models;
using Jobag.Domain.Services.Communications;

namespace Jobag.Domain.Services.Communications
{
    public interface IPostulantService
    {
        Task<PostulantResponse> GetByIdAsync(int id);
        Task<PostulantResponse> SaveAsync(Postulant postulant);
        Task<PostulantResponse> UpdateAsync(int id, Postulant postulant);
        Task<PostulantResponse> DeleteAsync(int id);
    }
}
