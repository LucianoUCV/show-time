using Context;
using Models;
using show_time.Interfaces;

namespace show_time.Repositories;

public class BandRepository : RepositoryBase<Band>, IBandRepository
{
    public BandRepository(ShowTimeContext context) : base(context)
    {
    }
}
