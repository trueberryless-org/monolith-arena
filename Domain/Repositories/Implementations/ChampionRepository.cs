using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class ChampionRepository : ARepository<Champion>, IChampionRepository
{
    public ChampionRepository(ModelDbContext context) : base(context)
    {
    }
}