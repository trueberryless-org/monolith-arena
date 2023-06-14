using Model.Entities.MonolithArena.GameContent;

namespace Model.Entities.MonolithArena.InGame.Logs;

[Table("TILE_LOGS_BT")]
public class TileLog : GameLog
{
    [Column("TILE_ID")]
    public int TileId { get; set; }
    public Tile Tile { get; set; }
}