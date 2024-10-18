using CarRentalWebsite.Data;
using CarRentalWebsite.Models;

namespace CarRentalWebsite.Business
{
    public interface IUserService
    {
        Task<Response> GetAllUsersAsync();
        Task<Response> GetByIdAsync(int id);
        Task<Response> AddUserAsync(UserDto user);
        Task<Response> UpdateUserAsync(int id , UserDto user);
        Task<Response> DeleteUserAsync(int id);
    }
}