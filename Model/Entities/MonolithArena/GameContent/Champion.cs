using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("CHAMPIONS")]
public class Champion : Tile
{
    public string Name { get; set; }
    
    [NotMapped]
    public List<ChampionInitiative> Initiatives { get; set; }

    [NotMapped]
    public List<ChampionAttack> Attacks { get; set; }
    
    [NotMapped]
    public List<ChampionFeature> Features { get; set; }

    public ChampionType ChampionType { get; set; }
    
    [Column("QUANTITY")]
    public int Quantity { get; set; }
}