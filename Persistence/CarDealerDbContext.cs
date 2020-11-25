using Car_Dealer_Website.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Dealer_Website.Persistence 
{
    public class CarDealerDbContext: DbContext
    {
        public CarDealerDbContext(DbContextOptions<CarDealerDbContext>options) : base(options)
        {
            
        }
        public DbSet<Make>Makes{get;set;}
    }
}