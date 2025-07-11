using Models;

namespace show_time.Interfaces;

public interface IFestivalRepository : IRepositoryBase<Festival>
{
    Task<Festival?> GetFestivalWithLineupAsync(Guid id); 
    Task SaveLineupAsync(Guid festivalId, IEnumerable<FestivalBand> lineup);
}
