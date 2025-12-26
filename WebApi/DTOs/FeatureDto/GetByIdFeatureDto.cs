namespace WebApi.DTOs.FeatureDto;
    public record GetByIdFeatureDto(
                                   int Id,
                                   string Title,
                                   string Subtitle,
                                   string Description,
                                   string VideoUrl,
                                   string ImageUrl);

