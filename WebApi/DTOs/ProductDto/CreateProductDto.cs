using WebApi.Entities;

namespace WebApi.DTOs.ProductDto;

public record CreateProductDto(
                               string Name,
                               string Description,
                               decimal Price,
                               string ImageUrl,
                               int CategoryId
                               );
 

