using System.Text.Json.Serialization;
using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("BANNER_HAS_DIRECTIONS_JT")]
public class BannerDirection
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public int Id { get; set; }
    
    [Column("BANNER_ID")]
    public int BannerId { get; set; }
    [JsonIgnore]
    public Banner Banner { get; set; }
    
    [Column("DIRECTION")]
    public DirectionType Direction { get; set; }
}