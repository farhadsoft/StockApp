using Application.DTOs;
using AutoMapper;
using Domain.Model;

namespace Application
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductSearchDto>();
        }
    }
}
