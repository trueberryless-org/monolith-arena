using Model.Entities.MonolithArena.InGame.Logs.TileLogs;

namespace Domain.Repositories.Implementations;

public class TilePreciseShotRepository : ARepository<TilePreciseShot>, ITilePreciseShotRepository
{
    public TilePreciseShotRepository(ModelDbContext context) : base(context)
    {
    }
}