namespace Model.Entities.MonolithArena;

[Table("TILES_BT")]
public class Tile
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("FACTION_ID")]
    public int FactionId { get; set; }
    public Faction Faction { get; set; }
}