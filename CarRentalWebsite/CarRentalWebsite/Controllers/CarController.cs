using CarRentalWebsite.Business;
using CarRentalWebsite.Data;
using CarRentalWebsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CarRentalWebsite.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService carService;
        public CarController(ICarService _carService){
            carService = _carService;
        }

        [HttpGet]
        public async Task<ActionResult<Response>> GetAllCarsAsync()
        {
            var Result = await carService.GetAllCarsAsync();
            if(Result.Success)
                return Ok(Result);
            else return BadRequest(Result.Message);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Response>> GetCarByIdAsync(int id){
            var Result = await carService.GetCarByIdAsync(id);
            if(Result.Success)
                return Ok(Result);
            else return BadRequest(Result.Message);
        }

        [HttpPost]
        public async Task<ActionResult<Response>> AddCarAsync(CarDto dto){
            var Result = await carService.AddCarAsync(dto);
            if(Result.Success)
                return Ok(Result);
            else return BadRequest(Result.Message);
        }

        [HttpPut]
        public async Task<ActionResult<Response>> UpdateCarAsync(int id , CarDto dto){
            var Result = await carService.UpdateCarAsync(id , dto);
            if(Result.Success)
                return Ok(Result);
            else return BadRequest(Result.Message);
        }

        [HttpDelete]
        public async Task<ActionResult<Response>> DeleteCarAsync(int id){
            var Result = await carService.DeleteCarAsync(id);
            if(Result.Success)
                return Ok(Result);
            else return BadRequest(Result.Message);
        }
    }

}