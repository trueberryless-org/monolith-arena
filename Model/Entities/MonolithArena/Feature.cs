namespace Model.Entities.MonolithArena;

[Table("FEATURES")]
public class Feature
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public FeatureType FeatureType { get; set; }
}