using Car_Dealer_Website.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Dealer_Website.Persistence 
{
    public class CarDealerDbContext: DbContext
    {
        public DbSet<Make>Makes{get;set;}
        public DbSet<Feature>Features {get;set;}
        public CarDealerDbContext(DbContextOptions<CarDealerDbContext>options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf => 
            new { vf.VehicleId, vf.FeatureId});
        }
        
    }
}