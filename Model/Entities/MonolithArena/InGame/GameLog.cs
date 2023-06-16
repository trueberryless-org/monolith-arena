using Model.Entities.Authentication;
using Model.Entities.MonolithArena.Enums;
using Model.Entities.MonolithArena.GameContent;
using Direction = Model.Entities.MonolithArena.GameContent.Direction;

namespace Model.Entities.MonolithArena.InGame;

[Table("GAME_LOGS_BT")]
public class GameLog
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("GAME_ID")]
    public int GameId { get; set; }
    public Game Game { get; set; }
    
    [Column("POSITION_ID")]
    public int PositionId { get; set; }
    public Position Position { get; set; }
    
    [Column("USER_ID")]
    public int UserId { get; set; }
    public User User { get; set; }
    
    [Column("TILE_ID")]
    public int? TileId { get; set; }
    public Tile? Tile { get; set; }
    
    [Column("FIELD_ID")]
    public int? FieldId { get; set; }
    public Field? Field { get; set; }
    
    [Column("FACING")]
    public int? DirectionId { get; set; }
    public Direction? Direction { get; set; }
    
    [Column("LOG_TYPE")]
    public GameLogType LogType { get; set; }
}