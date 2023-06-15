using Model.Entities.MonolithArena.InGame.Logs;

namespace Domain.Repositories.Implementations;

public class TileLogRepository : ARepository<TileLog>, ITileLogRepository
{
    public TileLogRepository(ModelDbContext context) : base(context)
    {
    }
}