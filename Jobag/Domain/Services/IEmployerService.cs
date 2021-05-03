using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jobag.Domain.Models;
using Jobag.Domain.Services.Communications;

namespace Jobag.Domain.Services
{
    public interface IEmployerService
    {
        Task<EmployerResponse> SaveAsync(Employer employer);
        Task<EmployerResponse> UpdateAsync(int id, Employer employer);
        Task<EmployerResponse> DeleteAsync(int id);
        Task<EmployerResponse> GetByIdAsync(int id);
    }
}
