using AutoMapper;
using WebApi.DTOs.FeatureDto;
using WebApi.DTOs.MessageDto;
using WebApi.DTOs.ProductDto;
using WebApi.Entities;

namespace WebApi.Mapping;

public class GeneralMapping : Profile
{
    public GeneralMapping() 
    {
        CreateMap<Feature, ResultFeatureDto>().ReverseMap();
        CreateMap<Feature, CreateFeatureDto>().ReverseMap();
        CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();
        CreateMap<Feature, UpdateFeatureDto>().ReverseMap();

        CreateMap<Message, ResultMessageDto>().ReverseMap();
        CreateMap<Message, CreateMessageDto>().ReverseMap();
        CreateMap<Message, GetByIdMessageDto>().ReverseMap();
        CreateMap<Message, UpdateMessageDto>().ReverseMap();

        CreateMap<Product, CreateProductDto>().ReverseMap();
        CreateMap<Product, ResultProductWithCategoryDto>().ForMember(x=>x.CategoryName, y=>y.MapFrom(z=>z.Category.Name)).ReverseMap();
    }
}
