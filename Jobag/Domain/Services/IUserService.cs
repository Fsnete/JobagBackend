using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jobag.Domain.Models;
using Jobag.Domain.Services.Communications;

namespace Jobag.Domain.Services
{
    public interface IUserService
    {
        Task<UserResponse> GetByIdAsync(int id);
        Task<UserResponse> SaveAsync(User user);
        Task<UserResponse> UpdateAsync(int id, User user);
        Task<UserResponse> DeleteAsync(int id);
    }
}
