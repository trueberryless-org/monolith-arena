using System.Text.Json.Serialization;
using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("RUNE_HAS_DIRECTIONS_JT")]
public class RuneDirection
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public int Id { get; set; }
    
    [Column("RUNE_ID")]
    public int RuneId { get; set; }
    [JsonIgnore]
    public Rune Rune { get; set; }
    
    [Column("DIRECTION")]
    public DirectionType Direction { get; set; }
}