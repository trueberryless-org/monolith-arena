using Model.Entities.MonolithArena.InGame.Logs.TileLogs;

namespace Domain.Repositories.Implementations;

public class TileDiscardRepository : ARepository<TileDiscard>, ITileDiscardRepository
{
    public TileDiscardRepository(ModelDbContext context) : base(context)
    {
    }
}