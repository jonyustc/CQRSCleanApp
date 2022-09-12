using Application.Dtos;
using AutoMapper;
using Domain;

namespace Application.Helper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<CreateProductDto,Product>();
        }
    }
}