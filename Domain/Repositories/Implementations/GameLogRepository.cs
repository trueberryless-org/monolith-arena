using Model.Entities.MonolithArena.InGame;

namespace Domain.Repositories.Implementations;

public class GameLogRepository : ARepository<GameLog>, IGameLogRepository
{
    public GameLogRepository(ModelDbContext context) : base(context)
    {
    }
}