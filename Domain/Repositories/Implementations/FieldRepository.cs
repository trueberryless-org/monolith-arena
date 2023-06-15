using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class FieldRepository : ARepository<Field>, IFieldRepository
{
    public FieldRepository(ModelDbContext context) : base(context)
    {
    }
}