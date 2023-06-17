namespace Model.Entities.MonolithArena.GameContent;

[Table("BANNERS")]
public class Banner : Champion
{
    [Column("SPECIAL_FEATURE_ID")]
    public int SpecialFeatureId { get; set; }
    public Feature SpecialFeature { get; set; }

    [Column("HEALTH")] public int Health = 20;
}