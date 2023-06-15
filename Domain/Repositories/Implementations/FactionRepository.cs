using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class FactionRepository : ARepository<Faction>, IFactionRepository
{
    public FactionRepository(ModelDbContext context) : base(context)
    {
    }
}