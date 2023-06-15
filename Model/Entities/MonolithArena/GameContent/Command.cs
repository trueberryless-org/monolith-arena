using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("ORDER_COMMANDS")]
public class Command : Order
{
    public OrderType OrderType { get; set; }
}