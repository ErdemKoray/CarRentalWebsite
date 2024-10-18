using CarRentalWebsite.Models;
using CarRentalWebsite.Data;
using CarRentalWebsite.Data.Abstract;

namespace CarRentalWebsite.Business
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public async Task<Response> AddUserAsync(UserDto user)
        {
            var Response = new Response();
            try
            {
                var User = new User(){
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    DateOfBirth = user.DateOfBirth,
                    LicanseNumber = user.LicanseNumber,
                    LicanseIssueDate = user.LicanseIssueDate,
                    Password = user.Password,
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                };
                await userRepository.AddAsync(User);
                await userRepository.SaveAsync();
                Response.Data = User;
                Response.Message = "User Added Successfully";
            }catch(Exception ex)
            {
                Response.Success = false;
                Response.Message = $"An error occurred while adding the user : {ex.Message}";
            }
            return Response;
        }

        public async Task<Response> DeleteUserAsync(int id)
        {
            var Response = new Response();
            try
            {
                var User = await userRepository.GetByIdAsync(id);
                if(User == null)
                {
                    Response.Success = false;
                    Response.Message = "User not found.";
                }
                else
                {
                    await userRepository.DeleteAsync(User);
                    await userRepository.SaveAsync();
                    Response.Message = "User deleted successfully.";
                    Response.Data = User;
                }
            }catch(Exception ex)
            {
                Response.Success = false;
                Response .Message = $"An error occurred while deleting the user : {ex.Message}";
            }
            return Response;
        }

        public async Task<Response> GetAllUsersAsync()
        {
            var Response = new Response();
            try
            {
                var Users = await userRepository.GetAllAsync();
                if(Users == null)
                {
                    Response.Success = false;
                    Response.Message = "User not found.";
                }
                else
                {
                    Response.Message = "Users retrieved successfully.";
                    Response.Data = Users;
                }
            }
            catch (Exception ex)
            {
                Response.Success = false;
                Response.Message = $"An error occurred while retrieving users : {ex.Message}";                
            }
            return Response;
        }

        public async Task<Response> GetByIdAsync(int id)
        {
            var Response = new Response();
            try
            {
                var User = await userRepository.GetByIdAsync(id);
                if(User == null)
                {
                    Response.Success = false;
                    Response.Message = "User not found.";
                }
                else
                {
                    Response.Data = User;
                    Response.Message = "User retrived successfully.";
                }
            }
            catch (Exception ex)
            {
                Response.Success = false;
                Response.Message = $"An error occurred while retrieving the user : {ex.Message}";
            }
            return Response;
        }

        public async Task<Response> UpdateUserAsync(int id, UserDto user)
        {
            var Response = new Response();
            try
            {
                var User = await userRepository.GetByIdAsync(id);
                if(User == null)
                {
                    Response.Success = false;
                    Response.Message = "User not found.";
                }
                else
                {
                    User.FirstName = user.FirstName;
                    User.LastName = user.LastName;
                    User.DateOfBirth = user.DateOfBirth;
                    User.LicanseNumber = user.LicanseNumber;
                    User.LicanseIssueDate = user.LicanseIssueDate;
                    User.Password = user.Password;
                    User.Email = user.Email;
                    User.PhoneNumber = user.PhoneNumber;
                    await userRepository.UpdateAsync(User);
                    await userRepository.SaveAsync();
                    Response.Data = User;
                    Response.Message = "User updated successfully.";
                }
            }
            catch (Exception ex)
            {
                Response.Success = false;
                Response.Message = $"An error occurred while updating the user : {ex.Message}";
            }
            return Response;
        }
    }
}