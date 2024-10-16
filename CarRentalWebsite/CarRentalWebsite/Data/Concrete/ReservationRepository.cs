using CarRentalWebsite.Data.Abstract;
using CarRentalWebsite.Models;

namespace CarRentalWebsite.Data.Concrete
{
    public class ReservationRepository : BaseRepository<Reservation> , IReservationRepository
    {
        public ReservationRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}