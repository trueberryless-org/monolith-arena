using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("RUNES")]
public class Rune : Tile
{
    public RuneType RuneType { get; set; }

    public List<RuneDirection> Directions { get; set; }
    
    public List<RuneFeature> Features { get; set; }
    
    [Column("SPECIAL_FEATURE_ID")]
    public int SpecialFeatureId { get; set; }
    public Feature SpecialFeature { get; set; }
}