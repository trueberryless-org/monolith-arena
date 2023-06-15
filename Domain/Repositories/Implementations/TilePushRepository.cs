using Model.Entities.MonolithArena.InGame.Logs.TileLogs.TileFieldLogs;

namespace Domain.Repositories.Implementations;

public class TilePushRepository : ARepository<TilePush>, ITilePushRepository
{
    public TilePushRepository(ModelDbContext context) : base(context)
    {
    }
}