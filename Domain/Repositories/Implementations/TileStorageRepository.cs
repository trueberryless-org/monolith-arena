using Model.Entities.MonolithArena.InGame.Logs.TileLogs;

namespace Domain.Repositories.Implementations;

public class TileStorageRepository : ARepository<TileStorage>, ITileStorageRepository
{
    public TileStorageRepository(ModelDbContext context) : base(context)
    {
    }
}