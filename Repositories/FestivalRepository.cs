using Context;
using Microsoft.EntityFrameworkCore;
using Models;
using show_time.Interfaces;

namespace show_time.Repositories;

public class FestivalRepository : RepositoryBase<Festival>, IFestivalRepository
{
    private readonly ShowTimeContext _context;

    public FestivalRepository(ShowTimeContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Festival?> GetFestivalWithLineupAsync(Guid id)
    {
        return await _context.Festivals
            .Include(f => f.FestivalBands)
                .ThenInclude(fb => fb.Band)
            .FirstOrDefaultAsync(f => f.Id == id);
    }

    public async Task SaveLineupAsync(Guid festivalId, IEnumerable<FestivalBand> lineup)
    {
        var current = _context.FestivalBands.Where(fb => fb.FestivalId == festivalId);
        _context.FestivalBands.RemoveRange(current);
        await _context.FestivalBands.AddRangeAsync(lineup);
        await _context.SaveChangesAsync();
    }
}
