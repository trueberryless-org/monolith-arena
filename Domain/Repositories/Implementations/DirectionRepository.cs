using Direction = Model.Entities.MonolithArena.GameContent.Direction;

namespace Domain.Repositories.Implementations;

public class DirectionRepository : ARepository<Direction>, IDirectionRepository
{
    public DirectionRepository(ModelDbContext context) : base(context)
    {
    }
}