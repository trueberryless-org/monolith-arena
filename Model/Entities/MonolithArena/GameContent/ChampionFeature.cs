using System.Text.Json.Serialization;
using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("CHAMPION_HAS_FEATURES_JT")]
public class ChampionFeature
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public int Id { get; set; }
    
    [Column("CHAMPION_ID")]
    public int ChampionId { get; set; }
    [JsonIgnore]
    public Champion Champion { get; set; }
    
    [Column("FEATURE")]
    public FeatureType Feature { get; set; }

    [Column("QUANTITY")] 
    public int Quantity { get; set; } = 1;
}