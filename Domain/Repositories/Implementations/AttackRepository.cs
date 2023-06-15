using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class AttackRepository : ARepository<Attack>, IAttackRepository
{
    public AttackRepository(ModelDbContext context) : base(context)
    {
    }
}