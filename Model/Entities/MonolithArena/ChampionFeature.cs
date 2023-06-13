namespace Model.Entities.MonolithArena;

[Table("CHAMPION_HAS_FEATURES_JT")]
public class ChampionFeature
{
    [Column("CHAMPION_ID")]
    public int ChampionId { get; set; }
    public Champion Champion { get; set; }
    
    [Column("FEATURE_ID")]
    public int FeatureId { get; set; }
    public Feature Feature { get; set; }
}