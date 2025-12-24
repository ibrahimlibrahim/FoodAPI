namespace WebApi.DTOs;

public record GetByIdContactDto(
                               int Id,
                               string MapLocation,
                               string Address,
                               string Phone,
                               string Email,
                               string OpenHours
                               );
