using Model.Entities.MonolithArena.InGame.Logs;

namespace Domain.Repositories.Implementations;

public class BattleStartRepository : ARepository<BattleStart>, IBattleStartRepository
{
    public BattleStartRepository(ModelDbContext context) : base(context)
    {
    }
}