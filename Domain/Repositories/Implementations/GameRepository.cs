using Model.Entities.MonolithArena.InGame;

namespace Domain.Repositories.Implementations;

public class GameRepository : ARepository<Game>, IGameRepository
{
    public GameRepository(ModelDbContext context) : base(context)
    {
    }
}