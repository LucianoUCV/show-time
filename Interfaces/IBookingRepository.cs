using Models;

namespace show_time.Interfaces;

public interface IBookingRepository : IRepositoryBase<Booking>
{
    Task<bool> HasBookingAsync(Guid userId, Guid festivalId);
    Task<IEnumerable<Booking>> GetBookingsForUserAsync(Guid userId);
}
