using Context;
using Interfaces;
using Models;
using show_time.Interfaces;

namespace show_time.Repositories;

public class FestivalBandRepository : RepositoryBase<FestivalBand>, IFestivalBandRepository
{
    public FestivalBandRepository(ShowTimeContext context) : base(context)
    {
    }
}
