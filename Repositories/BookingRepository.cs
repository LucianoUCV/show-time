using Context;
using Microsoft.EntityFrameworkCore;
using Models;
using show_time.Interfaces;

namespace show_time.Repositories;

public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
{
    private readonly ShowTimeContext _context;
    public BookingRepository(ShowTimeContext context) : base(context)
    {
        _context = context;
    }
    public async Task<bool> HasBookingAsync(Guid userId, Guid festivalId)
    {
        return await _context.Bookings
            .AnyAsync(b => b.UserId == userId && b.FestivalId == festivalId);
    }
    public async Task<IEnumerable<Booking>> GetBookingsForUserAsync(Guid userId)
    {
        return await _context.Bookings
            .Where(b => b.UserId == userId)
            .Include(b => b.Festival) 
            .OrderByDescending(b => b.DateCreated) 
            .ToListAsync();
    }
}
