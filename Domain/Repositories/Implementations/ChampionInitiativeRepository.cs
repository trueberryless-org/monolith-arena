using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class ChampionInitiativeRepository : ARepository<ChampionInitiative>, IChampionInitiativeRepository
{
    public ChampionInitiativeRepository(ModelDbContext context) : base(context)
    {
    }
}