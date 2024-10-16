using CarRentalWebsite.Models;
using CarRentalWebsite.Data.Abstract;
using CarRentalWebsite.Data;

namespace CarRentalWebsite.Business
{
    public class CarService : ICarService
    {
        private readonly ICarRepository carRepository;
        public CarService(ICarRepository _carRepository)
        {
            carRepository = _carRepository;
        }
        public async Task<Response> AddCarAsync(CarDto dto)
        {
            var Response = new Response();
            try
            {
                var Car = new Car()
                {
                    Brand = dto.Brand,
                    Model = dto.Model,
                    LicensePlate = dto.LicensePlate,
                    Year = dto.Year,
                    FuelType = dto.FuelType,
                    Transmission = dto.Transmission,
                    DailyPrice = dto.DailyPrice,
                    IsAvailable = true,
                    Description = dto.Description,
                };
                await carRepository.AddAsync(Car);
                await carRepository.SaveAsync();
                Response.Data = Car;
                Response.Message = "Car added successfully";
            }catch(Exception ex)
            {
                Response.Success = false;
                Response.Message = $"An error occurred while adding the car : {ex.Message}";
            }
            return Response;
        }

        public async Task<Response> DeleteCarAsync(int id)
        {
            var Response = new Response();
            try
            {
                var Car = await carRepository.GetByIdAsync(id);
                if(Car == null)
                {
                    Response.Success = false;
                    Response.Message = "Car not found";
                }
                else
                {
                    await carRepository.DeleteAsync(Car);
                    await carRepository.SaveAsync();
                    Response.Message = "Car deleted successfully.";
                }
            }catch(Exception ex)
            {
                Response.Success = false;
                Response.Message = $"An error occurred while deleting the car : {ex.Message}";
            }
            return Response;
        }

        public async Task<Response> GetAllCarsAsync()
        {
            var Response = new Response();
            try
            {
                var Cars = await carRepository.GetAllAsync();
                if(Cars == null)
                {
                    Response.Success = false;
                    Response.Message = "Car are not found.";
                }
                else{
                    Response.Data = Cars;
                    Response.Message = "Cars retrieved successfully.";
                }
            }catch(Exception ex)
            {
                Response.Success = false;
                Response.Message = $"An error occurred while retrieved the cars : {ex.Message}";
            }
            return Response;
        }

        public async Task<Response> GetCarByIdAsync(int id)
        {
            var Response = new Response();
            try
            {
                var Car = await carRepository.GetByIdAsync(id);
                if(Car == null)
                {
                    Response.Success = false;
                    Response.Message = "Car not found.";
                }
                else
                {
                    Response.Data = Car;
                    Response.Message = "Cars retrieved successfully.";
                }
            }catch(Exception ex)
            {
                Response.Success = false;
                Response.Message = $"An error occurred while retrieved the car : {ex.Message}";
            }
            return Response;
        }

        public async Task<Response> UpdateCarAsync(int id, CarDto dto)
        {
            var Response = new Response();
            try
            {
                var Car =  await carRepository.GetByIdAsync(id);
                if(Car == null)
                {
                    Response.Success = false;
                    Response.Message = "Car not found.";
                }
                else
                {
                    Car.Brand = dto.Brand;
                    Car.Model = dto.Model;
                    Car.LicensePlate = dto.LicensePlate;
                    Car.Year = dto.Year;
                    Car.FuelType = dto.FuelType;
                    Car.Transmission = dto.Transmission;
                    Car.DailyPrice = dto.DailyPrice;
                    Car.Description = dto.Description;
                    await carRepository.UpdateAsync(Car);
                    await carRepository.SaveAsync();
                    Response.Data = Car;
                    Response.Message = "Car updated successfully.";
                }
            }catch(Exception ex)
            {
                Response.Success = false;
                Response.Message = $"An error occurred while updating the car : {ex.Message}";
            }
            return Response;
        }
    }
}