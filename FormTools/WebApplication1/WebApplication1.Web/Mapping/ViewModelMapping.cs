using AutoMapper;
using WebApplication1.Web.Models;
using WebApplication1.Web.Models.ViewModels;

namespace WebApplication1.Web.Mapping
{
    public class ViewModelMapping:Profile
    {
        public ViewModelMapping()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Visitor, VisitorViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.commenDate, opt => opt.MapFrom(src => src.CommentDate))
                .ReverseMap();
        }
    }
}
