namespace Model.Entities.MonolithArena;

[Table("RUNES")]
public class Rune : Tile
{
    public RuneType RuneType { get; set; }

    [NotMapped]
    public List<RuneDirection> Directions { get; set; }
    
    [NotMapped]
    public List<RuneFeature> Features { get; set; }
}