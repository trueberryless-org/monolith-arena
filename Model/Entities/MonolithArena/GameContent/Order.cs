using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("ORDERS_BT")]
public class Order : Tile
{
}

[Table("ORDER_LOGIC_GATES")]
public class LogicGate : Order
{
    public LogicGateType LogicGateType { get; set; }
    
    [Column("OPTION_ONE_ORDER_ID")]
    public int OptionOneOrderId { get; set; }
    public Order OptionOneOrder { get; set; }
    
    [Column("OPTION_TWO_ORDER_ID")]
    public int OptionTwoOrderId { get; set; }
    public Order OptionTwoOrder { get; set; }
}

[Table("ORDER_COMMANDS")]
public class Command : Order
{
    public OrderType OrderType { get; set; }
}