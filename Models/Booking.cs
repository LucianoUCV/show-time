using System.ComponentModel.DataAnnotations;

namespace Models;

public class Booking
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public ApplicationUser? User { get; set; }
    public string? Email { get; set; }
    public DateTime Date { get; set; }
    public Double Price { get; set; }
    public Guid FestivalId { get; set; }
    public Festival? Festival { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
}
