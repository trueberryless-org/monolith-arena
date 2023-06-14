﻿using Model.Entities.MonolithArena.InGame.Logs;

namespace Model.Entities.MonolithArena.InGame;

[Table("POSITIONS")]
public class Position
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("GAME_ID")]
    public int GameId { get; set; }
    public Game Game { get; set; }
    
    public int Order { get; set; }
    
    [NotMapped] 
    public List<TileField> Fields { get; set; }
    
    [NotMapped]
    public List<GameLog> Logs { get; set; }
}