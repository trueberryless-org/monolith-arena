using System.Text.Json.Serialization;
using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("CHAMPION_HAS_ATTACKS_JT")]
public class ChampionAttack
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public int Id { get; set; }
    
    [Column("CHAMPION_ID")]
    public int ChampionId { get; set; }
    [JsonIgnore]
    public Champion Champion { get; set; }
    
    [Column("ATTACK")]
    public AttackType Attack { get; set; }
    
    [Column("DIRECTION")]
    public DirectionType Direction { get; set; }

    [Column("STRENGTH")]
    public int Strength { get; set; } = 1;
}