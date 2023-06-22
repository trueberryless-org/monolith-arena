using System.Text.Json.Serialization;
using Model.Entities.MonolithArena.Enums;
using Model.Entities.MonolithArena.GameContent;

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
    [JsonIgnore]
    public Position Position { get; set; }
    
    [Column("DIRECTION")]
    public DirectionType Direction { get; set; }
}