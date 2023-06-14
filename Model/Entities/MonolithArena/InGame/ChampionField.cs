using Model.Entities.MonolithArena.GameContent;
using Direction = Model.Entities.MonolithArena.GameContent.Direction;

namespace Model.Entities.MonolithArena.InGame;

[Table("CHAMPION_OCCUPIES_FIELD_JT")]
public class ChampionField
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
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