using Model.Entities.MonolithArena.InGame.Logs.TileLogs.TileFieldLogs;

namespace Domain.Repositories.Implementations;

public class TileFieldDirectionLogRepository : ARepository<TileFieldDirectionLog>, ITileFieldDirectionLogRepository
{
    public TileFieldDirectionLogRepository(ModelDbContext context) : base(context)
    {
    }
}