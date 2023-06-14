using Model.Entities.MonolithArena.GameContent;

namespace Model.Entities.MonolithArena.InGame.Logs.TileLogs;

[Table("TILE_FIELD_LOGS_BT")]
public class TileFieldLog : TileLog
{
    [Column("FIELD_ID")]
    public int FieldId { get; set; }
    public Field Field { get; set; }
}