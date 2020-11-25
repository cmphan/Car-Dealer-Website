using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Car_Dealer_Website.Models;
using Car_Dealer_Website.Persistence;
using Car_Dealer_Website.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Car_Dealer_Website.Controllers 
{
    public class MakesController: Controller 
    {
        private readonly CarDealerDbContext context;
        private readonly IMapper mapper;

        public MakesController(CarDealerDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>>GetMakes()
        {
            var makes = await context.Makes.Include(m=> m.Models).ToListAsync();
            return mapper.Map<List<Make>,List<MakeResource>>(makes);
        }
    }
}