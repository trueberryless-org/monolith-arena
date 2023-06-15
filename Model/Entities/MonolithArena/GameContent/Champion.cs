using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("CHAMPIONS")]
public class Champion : Tile
{
    [Column("NAME")]
    public string Name { get; set; }

    public List<ChampionAttack> Attacks { get; set; }
    
    public List<ChampionFeature> Features { get; set; }
    
    public List<ChampionInitiative> Initiatives { get; set; }

    public ChampionType ChampionType { get; set; }
    
    [Column("QUANTITY")]
    public int Quantity { get; set; }
}