﻿namespace Models;

public class Festival
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Location { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Description { get; set; }
    public ICollection<FestivalBand>? FestivalBands { get; set; }
    public ICollection<Booking>? Bookings { get; set; }
}

