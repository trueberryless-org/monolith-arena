using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class FeatureRepository : ARepository<Feature>, IFeatureRepository
{
    public FeatureRepository(ModelDbContext context) : base(context)
    {
    }
}