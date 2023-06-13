namespace Model.Entities.MonolithArena;

[Table("RUNE_HAS_FEATURES_JT")]
public class RuneFeature
{
    [Column("RUNE_ID")]
    public int RuneId { get; set; }
    public Rune Rune { get; set; }
    
    [Column("FEATURE_ID")]
    public int FeatureId { get; set; }
    public Feature Feature { get; set; }
}