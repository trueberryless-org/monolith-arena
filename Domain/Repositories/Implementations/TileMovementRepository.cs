using Model.Entities.MonolithArena.InGame.Logs.TileLogs.TileFieldLogs.TileFieldDirectionLogs;

namespace Domain.Repositories.Implementations;

public class TileMovementRepository : ARepository<TileMovement>, ITileMovementRepository
{
    public TileMovementRepository(ModelDbContext context) : base(context)
    {
    }
}