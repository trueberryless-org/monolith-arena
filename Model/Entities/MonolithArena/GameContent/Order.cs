using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("ORDERS")]
public class Order : Tile
{
    public OrderType OrderType { get; set; }
}