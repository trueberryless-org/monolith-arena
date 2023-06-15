using Position = Model.Entities.MonolithArena.InGame.Position;

namespace Domain.Repositories.Implementations;

public class PositionRepository : ARepository<Position>, IPositionRepository
{
    public PositionRepository(ModelDbContext context) : base(context)
    {
    }
}