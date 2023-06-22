using System.Text.Json.Serialization;

namespace Model.Entities.MonolithArena.GameContent;

[Table("CHAMPION_HAS_INITIATIVES_JT")]
public class ChampionInitiative
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public int Id { get; set; }
    
    [Column("CHAMPION_ID")]
    public int ChampionId { get; set; }
    [JsonIgnore]
    public Champion Champion { get; set; }
    
    [Column("INITIATIVE")]
    public int Initiative { get; set; }
}