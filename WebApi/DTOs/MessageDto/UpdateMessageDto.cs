namespace WebApi.DTOs.MessageDto;

public record UpdateMessageDto(
                              int Id,
                              string FullName,
                              string Email,
                              string Subject,
                              string Details,
                              DateTime SendDate,
                              bool IsRead);
