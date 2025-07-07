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
    public DbSet<FestivalBand>? FestivalBands { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FestivalBand>()
            .HasKey(sc => new { sc.FestivalId, sc.BandId });

        modelBuilder.Entity<FestivalBand>()
            .HasOne(sc => sc.Festival)
            .WithMany(s => s.FestivalBands)
            .HasForeignKey(sc => sc.FestivalId);

        modelBuilder.Entity<FestivalBand>()
            .HasOne(sc => sc.Band)
            .WithMany(c => c.FestivalBands)
            .HasForeignKey(sc => sc.BandId);
    }
}
