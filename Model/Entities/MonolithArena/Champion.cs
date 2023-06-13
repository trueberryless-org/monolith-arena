namespace Model.Entities.MonolithArena;

[Table("CHAMPIONS")]
public class Champion : Tile
{
    [NotMapped]
    public List<ChampionInitiative> Initiatives { get; set; }

    [NotMapped]
    public List<ChampionAttack> Attacks { get; set; }
    
    [NotMapped]
    public List<ChampionFeature> Features { get; set; }

    public ChampionType ChampionType { get; set; }
}