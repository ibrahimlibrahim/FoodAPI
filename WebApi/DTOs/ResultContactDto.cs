namespace WebApi.DTOs;

public record ResultContactDto(
                               int Id,
                               string MapLocation,
                               string Address,
                               string Phone,
                               string Email,
                               string OpenHours);
