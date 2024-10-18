using CarRentalWebsite.Models;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace CarRentalWebsite.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){   }



        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        

    }
}