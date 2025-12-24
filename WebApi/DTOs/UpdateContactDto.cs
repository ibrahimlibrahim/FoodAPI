namespace WebApi.DTOs
{
    public record UpdateContactDto(
                                   int Id,
                                   string MapLocation,
                                   string Address,
                                   string Phone,
                                   string Email,
                                   string OpenHours
                                   );

}
