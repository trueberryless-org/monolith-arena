using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("RUNES")]
public class Rune : Tile
{
    public RuneType RuneType { get; set; }

    [NotMapped]
    public List<RuneDirection> Directions { get; set; }
    
    [NotMapped]
    public List<RuneFeature> Features { get; set; }
}