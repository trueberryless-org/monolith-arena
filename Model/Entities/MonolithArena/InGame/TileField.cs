using Model.Entities.MonolithArena.GameContent;
using Direction = Model.Entities.MonolithArena.GameContent.Direction;

namespace Model.Entities.MonolithArena.InGame;

[Table("TILE_OCCUPIES_FIELD_JT")]
public class TileField
{
    [Column("FIELD_ID")]
    public int FieldId { get; set; }
    public Field Field { get; set; }
    
    [Column("TILE_ID")]
    public int TileId { get; set; }
    public Tile Tile { get; set; }
    
    [Column("POSITION_ID")]
    public int PositionId { get; set; }
    public Position Position { get; set; }
    
    [Column("FACING")]
    public int DirectionId { get; set; }
    public Direction Direction { get; set; }
}