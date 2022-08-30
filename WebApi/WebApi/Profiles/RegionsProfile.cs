using AutoMapper;

namespace WebApi.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Model.Domain.Region, Model.DTO.Region>().ReverseMap();
                //.ForMember(dest => dest.Id, options => options.MapFrom(src => src.RegionId));
        }
    }
}
