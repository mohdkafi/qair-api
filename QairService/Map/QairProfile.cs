using AutoMapper;
using QairService.DB.Models;
using QairService.Models;
namespace QairService.Map
{
    public class QairProfile : Profile
    {
        public QairProfile()
        {
            CreateMap<Qair, QairDTO>()
                .ReverseMap();
        }
    }
}
