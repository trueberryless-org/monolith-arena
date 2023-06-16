namespace Model.Entities.MonolithArena.GameContent;

[Table("BANNERS")]
public class Banner : Champion
{
    [Column("NAME")] 
    public new string Name = "Banner";
    
    [Column("SPECIAL_FEATURE_ID")]
    public int SpecialFeatureId { get; set; }
    public Feature SpecialFeature { get; set; }
    
    public List<ChampionInitiative> Initiatives { get; set; }

    [Column("HEALTH")] public int Health = 20;
}