using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class ChampionAttackRepository : ARepository<ChampionAttack>, IChampionAttackRepository
{
    public ChampionAttackRepository(ModelDbContext context) : base(context)
    {
    }
}