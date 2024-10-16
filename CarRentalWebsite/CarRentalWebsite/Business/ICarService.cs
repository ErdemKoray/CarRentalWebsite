using CarRentalWebsite.Data;
using CarRentalWebsite.Models;


namespace CarRentalWebsite.Business
{
    public interface ICarService
    {
        Task<Response> GetAllCarsAsync();
        Task<Response> GetCarByIdAsync(int id);
        Task<Response> AddCarAsync(CarDto dto);
        Task<Response> UpdateCarAsync(int id , CarDto dto);
        Task<Response> DeleteCarAsync(int id);
    }
}