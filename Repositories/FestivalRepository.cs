using Context;
using Models;
using show_time.Interfaces;

namespace show_time.Repositories;

public class FestivalRepository : RepositoryBase<Festival>, IFestivalRepository
{
    public FestivalRepository(ShowTimeContext context) : base(context)
    {
    }
}
