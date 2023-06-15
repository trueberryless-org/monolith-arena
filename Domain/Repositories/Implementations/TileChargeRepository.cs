using Model.Entities.MonolithArena.InGame.Logs.TileLogs.TileFieldLogs.TileFieldDirectionLogs;

namespace Domain.Repositories.Implementations;

public class TileChargeRepository : ARepository<TileCharge>, ITileChargeRepository
{
    public TileChargeRepository(ModelDbContext context) : base(context)
    {
    }
}