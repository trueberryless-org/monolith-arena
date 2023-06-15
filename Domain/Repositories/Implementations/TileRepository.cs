using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class TileRepository : ARepository<Tile>, ITileRepository
{
    public TileRepository(ModelDbContext context) : base(context)
    {
    }
}