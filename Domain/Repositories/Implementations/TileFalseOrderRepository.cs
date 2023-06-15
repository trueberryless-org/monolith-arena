using Model.Entities.MonolithArena.InGame.Logs.TileLogs.TileFieldLogs.TileFieldDirectionLogs;

namespace Domain.Repositories.Implementations;

public class TileFalseOrderRepository : ARepository<TileFalseOrder>, ITileFalseOrderRepository
{
    public TileFalseOrderRepository(ModelDbContext context) : base(context)
    {
    }
}