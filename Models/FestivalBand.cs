namespace Models;

public class FestivalBand
{
    public Guid FestivalId { get; set; }
    public Festival Festival { get; set; } = null!;
    public Guid BandId { get; set; }
    public Band Band { get; set; } = null!;
    public int Order { get; set; } 
}
