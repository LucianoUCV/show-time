using Microsoft.AspNetCore.Identity;

namespace Models;

public class ApplicationUser : IdentityUser<Guid>
{
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
