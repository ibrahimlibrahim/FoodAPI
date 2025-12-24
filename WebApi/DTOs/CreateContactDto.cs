namespace WebApi.DTOs
{
    public record CreateContactDto(
                                   string MapLocation,
                                   string Address,
                                   string Phone,
                                   string Email,
                                   string OpenHours);

}
