using Model.Entities.MonolithArena.InGame.Logs.TileLogs;

namespace Domain.Repositories.Implementations;

public class TileFieldLogRepository : ARepository<TileFieldLog>, ITileFieldLogRepository
{
    public TileFieldLogRepository(ModelDbContext context) : base(context)
    {
    }
}