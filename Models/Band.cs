using show_time.Enums;

namespace Models;

public class Band
{
    public Guid Id { get; set; }
    public string? Name { get; set; } 
    public Genre Genre { get; set; }
    public ICollection<FestivalBand>? FestivalBands { get; set; }
    //public ICollection<Member>? Members { get; set; }
}
