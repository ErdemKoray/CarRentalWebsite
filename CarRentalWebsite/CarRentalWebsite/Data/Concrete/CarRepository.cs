using CarRentalWebsite.Data.Abstract;
using CarRentalWebsite.Models;

namespace CarRentalWebsite.Data.Concrete
{
    public class CarRepository : BaseRepository<Car> , ICarRepository
    {
        public CarRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}