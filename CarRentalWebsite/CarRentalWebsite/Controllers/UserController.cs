using CarRentalWebsite.Business;
using CarRentalWebsite.Data;
using CarRentalWebsite.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;



namespace CarRentalWebsite.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        [HttpGet]
        public async Task<ActionResult<Response>> GetAllUsersAsync(){
            var Result = await userService.GetAllUsersAsync();
            if(Result.Success)
                return Ok(Result);
            else return BadRequest(Result.Message);
        }

        [HttpGet("id")]
        public async Task<ActionResult<Response>> GetUserByIdAsync(int id){
            var Result = await userService.GetByIdAsync(id);
            if(Result.Success)
                return Ok(Result);
            else return BadRequest(Result.Message);
        }

        [HttpPost]
        public async Task<ActionResult<Response>> AddUserAsync(UserDto user){
            var Result = await userService.AddUserAsync(user);
            if(Result.Success)
                return Ok(Result);
            else return BadRequest(Result.Message);
        }

        [HttpPut]
        public async Task<ActionResult<Response>> UpdateUserAsync(int id , UserDto user){
            var Result = await userService.UpdateUserAsync(id,user);
            if(Result.Success)
                return Ok(Result);
            else return BadRequest(Result.Message);
        }

        [HttpDelete]
        public async Task<ActionResult<Response>> DeleteUserAsync(int id){
            var Result = await userService.DeleteUserAsync(id);
            if(Result.Success)
                return Ok(Result);
            else return BadRequest(Result.Message);
        }
    }
}