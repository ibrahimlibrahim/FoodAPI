namespace WebApi.DTOs.ContactDto
{
    public record CreateContactDto(
                                   string MapLocation,
                                   string Address,
                                   string Phone,
                                   string Email,
                                   string OpenHours);

}
