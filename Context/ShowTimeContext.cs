namespace Context;
using Microsoft.EntityFrameworkCore;
using Models;

public class ShowTimeContext : DbContext
{
    public ShowTimeContext(DbContextOptions<ShowTimeContext> options) : base(options)
    {
    }
    public DbSet<Band>? Bands { get; set; } 
    public DbSet<Booking>? Bookings { get; set; }
    public DbSet<Festival>? Festivals { get; set; }
}
