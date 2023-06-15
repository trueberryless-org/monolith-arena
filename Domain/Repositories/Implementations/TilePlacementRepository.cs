using Model.Entities.MonolithArena.InGame.Logs.TileLogs.TileFieldLogs.TileFieldDirectionLogs;

namespace Domain.Repositories.Implementations;

public class TilePlacementRepository : ARepository<TilePlacement>, ITilePlacementRepository
{
    public TilePlacementRepository(ModelDbContext context) : base(context)
    {
    }
}