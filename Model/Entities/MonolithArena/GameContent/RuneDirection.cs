namespace Model.Entities.MonolithArena.GameContent;

[Table("RUNE_HAS_DIRECTIONS_JT")]
public class RuneDirection
{
    [Column("RUNE_ID")]
    public int RuneId { get; set; }
    public Rune Rune { get; set; }
    
    [Column("DIRECTION_ID")]
    public int DirectionId { get; set; }
    public Direction Direction { get; set; }
}