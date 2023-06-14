namespace Model.Entities.MonolithArena.GameContent;

[Table("FACTIONS")]
public class Faction
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("NAME")]
    public string Name { get; set; }
    
    [NotMapped]
    public List<Tile> Tiles { get; set; }
}