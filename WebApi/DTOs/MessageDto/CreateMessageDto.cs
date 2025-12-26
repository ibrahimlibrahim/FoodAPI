namespace WebApi.DTOs.MessageDto;

public record CreateMessageDto(
                          string FullName,
                          string Email,
                          string Subject,
                          string Details,
                          DateTime SendDate,
                          bool IsRead);
