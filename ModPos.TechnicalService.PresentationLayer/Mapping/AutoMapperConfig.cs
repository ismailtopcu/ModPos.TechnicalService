using AutoMapper;
using ModPos.TechnicalService.DtoLayer.Dtos.CategoryDto;
using ModPos.TechnicalService.DtoLayer.Dtos.CustomerDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ProductDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceDto;
using ModPos.TechnicalService.DtoLayer.Dtos.ServiceMovementsDto;
using ModPos.TechnicalService.EntityLayer.Concrete;

namespace ModPos.TechnicalService.PresentationLayer
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultCustomerDto, Customer>().ReverseMap();
            CreateMap<CreateCustomerDto, Customer>().ReverseMap();
            CreateMap<UpdateCustomerDto, Customer>().ReverseMap();

            CreateMap<ResultProductDto, Product>().ReverseMap();
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();

            CreateMap<ResultCategoryDto, Category>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();

            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();

            CreateMap<ResultServiceMovementsDto, ServiceMovements>().ReverseMap();
            CreateMap<CreateServiceMovementsDto, ServiceMovements>().ReverseMap();
            CreateMap<UpdateServiceMovementsDto, ServiceMovements>().ReverseMap();
        }
    }
}
