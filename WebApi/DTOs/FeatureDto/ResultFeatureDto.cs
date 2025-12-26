namespace WebApi.DTOs.FeatureDto;

public record ResultFeatureDto(
                              int Id,
                              string Title,
                              string Subtitle,
                              string Description,
                              string VideoUrl,
                              string ImageUrl);

