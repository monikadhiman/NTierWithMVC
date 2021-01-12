using NTier.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Core.Service
{
    public interface IUserService
    {
        Task<(bool, string)> CreateAsync(CreateUserDto createUserDto);
        Task<List<GetUserDto>> GetAllAsync();
        Task<GetUserDto> GetByIdAsync(Guid id);
        Task<(bool, string)> DeleteAsync(Guid id);
        Task<(bool, string)> UpdateAsync(UpdateUserDto  updateUserDto);
    }
}
