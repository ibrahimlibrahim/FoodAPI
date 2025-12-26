namespace WebApi.DTOs.ProductDto
{
    public record ResultProductWithCategoryDto(
                                               int Id,
                                               string Name,
                                               string Description,
                                               decimal Price,
                                               string ImageUrl,
                                               int CategoryId,
                                               string CategoryName);

}
