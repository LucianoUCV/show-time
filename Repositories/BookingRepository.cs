using Context;
using Models;
using show_time.Interfaces;

namespace show_time.Repositories;

public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
{
    public BookingRepository(ShowTimeContext context) : base(context)
    {
    }
}
