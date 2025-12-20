namespace WebApi.Entities;

public class Reservation
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public int People { get; set; }
    public string Message { get; set; }
    public string Status { get; set; }
}
