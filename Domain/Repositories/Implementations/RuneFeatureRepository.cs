using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class RuneFeatureRepository : ARepository<RuneFeature>, IRuneFeatureRepository
{
    public RuneFeatureRepository(ModelDbContext context) : base(context)
    {
    }
}