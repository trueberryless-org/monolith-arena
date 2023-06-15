using Model.Entities.MonolithArena.InGame;

namespace Domain.Repositories.Implementations;

public class UserGameRepository : ARepository<UserGame>, IUserGameRepository
{
    public UserGameRepository(ModelDbContext context) : base(context)
    {
    }
}