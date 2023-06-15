using Model.Entities.MonolithArena.InGame.Logs.TileLogs;

namespace Domain.Repositories.Implementations;

public class TileDrawRepository : ARepository<TileDraw>, ITileDrawRepository
{
    public TileDrawRepository(ModelDbContext context) : base(context)
    {
    }
}