using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("FACTIONS")]
public class Faction
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public int Id { get; set; }
    
    [Column("NAME")]
    public string Name { get; set; }
    
    public List<Tile> Tiles { get; set; }
    
    public FactionColor Color { get; set; }
}