﻿namespace Model.Entities.MonolithArena.GameContent;

[Table("TILES_BT")]
public class Tile
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID")]
    public int Id { get; set; }
    
    [Column("FACTION_ID")]
    public int FactionId { get; set; }
    public Faction Faction { get; set; }
    
    [Column("QUANTITY")]
    public int Quantity { get; set; }
}