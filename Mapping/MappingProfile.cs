using System.Linq;
using AutoMapper;
using Car_Dealer_Website.Models;
using Car_Dealer_Website.Resources;

namespace Car_Dealer_Website.Mapping 
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            //Domain to API Resource
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();

            //API Resource to Domain 
            CreateMap<VehicleResource,Vehicle>()
                .ForMember(v => v.ContactName, opt => opt.MapFrom(vr => vr.Contact.Name))
                .ForMember(v => v.ContacEmail, opt => opt.MapFrom(vr => vr.Contact.Email))
                .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone))
                .ForMember(v => v.Features, opt => opt.MapFrom(vr => vr.Features.Select(id => new VehicleFeature {FeatureId = id})));
        }
    }
}