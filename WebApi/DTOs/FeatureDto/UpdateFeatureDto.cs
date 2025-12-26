namespace WebApi.DTOs.FeatureDto;

public record UpdateFeatureDto(
                              int Id,
                              string Title,
                              string Subtitle,
                              string Description,
                              string VideoUrl,
                              string ImageUrl);

