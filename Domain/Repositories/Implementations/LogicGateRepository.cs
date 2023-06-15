using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class LogicGateRepository : ARepository<LogicGate>, ILogicGateRepository
{
    public LogicGateRepository(ModelDbContext context) : base(context)
    {
    }
}