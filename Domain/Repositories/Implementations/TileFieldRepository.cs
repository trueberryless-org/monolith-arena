using Model.Entities.MonolithArena.InGame;

namespace Domain.Repositories.Implementations;

public class TileFieldRepository : ARepository<TileField>, ITileFieldRepository
{
    public TileFieldRepository(ModelDbContext context) : base(context)
    {
    }
}