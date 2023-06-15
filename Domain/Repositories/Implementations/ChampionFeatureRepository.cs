using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class ChampionFeatureRepository : ARepository<ChampionFeature>, IChampionFeatureRepository
{
    public ChampionFeatureRepository(ModelDbContext context) : base(context)
    {
    }
}