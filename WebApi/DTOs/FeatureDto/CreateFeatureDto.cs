namespace WebApi.DTOs.FeatureDto;

public record CreateFeatureDto(
                              string Title,
                              string Subtitle,
                              string Description,
                              string VideoUrl,
                              string ImageUrl);


