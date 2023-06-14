using Direction = Model.Entities.MonolithArena.GameContent.Direction;

namespace Model.Entities.MonolithArena.InGame.Logs.TileLogs.TileFieldLogs;

[Table("TILE_FIELD_DIRECTION_LOGS_BT")]
public class TileFieldDirectionLog : TileFieldLog
{
    [Column("FACING")]
    public int DirectionId { get; set; }
    public Direction Direction { get; set; }
}