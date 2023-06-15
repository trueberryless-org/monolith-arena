using Model.Entities.MonolithArena.InGame.Logs.TileLogs;

namespace Domain.Repositories.Implementations;

public class TileManaChargeRepository : ARepository<TileManaCharge>, ITileManaChargeRepository
{
    public TileManaChargeRepository(ModelDbContext context) : base(context)
    {
    }
}