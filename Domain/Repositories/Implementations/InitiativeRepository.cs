using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class InitiativeRepository : ARepository<Initiative>, IInitiativeRepository
{
    public InitiativeRepository(ModelDbContext context) : base(context)
    {
    }
}