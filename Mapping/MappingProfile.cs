using AutoMapper;
using Car_Dealer_Website.Models;
using Car_Dealer_Website.Resources;

namespace Car_Dealer_Website.Mapping 
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}