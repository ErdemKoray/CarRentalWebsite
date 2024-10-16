using CarRentalWebsite.Data.Abstract;
using CarRentalWebsite.Models;

namespace CarRentalWebsite.Data.Concrete
{
    public class PaymentRepository : BaseRepository<Payment> , IPaymentRepository
    {
        public PaymentRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}