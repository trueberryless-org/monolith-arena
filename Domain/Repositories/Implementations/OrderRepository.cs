using Model.Entities.MonolithArena.GameContent;

namespace Domain.Repositories.Implementations;

public class OrderRepository : ARepository<Order>, IOrderRepository
{
    public OrderRepository(ModelDbContext context) : base(context)
    {
    }
}