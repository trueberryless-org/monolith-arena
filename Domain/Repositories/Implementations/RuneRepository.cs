using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class RuneRepository : ARepository<Rune>, IRuneRepository
{
    public RuneRepository(ModelDbContext context) : base(context)
    {
    }
}