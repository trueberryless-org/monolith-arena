using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class CommandRepository : ARepository<Command>, ICommandRepository
{
    public CommandRepository(ModelDbContext context) : base(context)
    {
    }
}