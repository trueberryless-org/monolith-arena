using Model.Entities.MonolithArena.InGame.Logs.TileLogs;

namespace Domain.Repositories.Implementations;

public class TileNetRepository : ARepository<TileNet>, ITileNetRepository
{
    public TileNetRepository(ModelDbContext context) : base(context)
    {
    }
}