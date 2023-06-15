using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class RuneDirectionRepository : ARepository<RuneDirection>, IRuneDirectionRepository
{
    public RuneDirectionRepository(ModelDbContext context) : base(context)
    {
    }
}