using Model.Entities.Authentication;
using Model.Entities.MonolithArena.GameContent;

namespace Model.Entities.MonolithArena.InGame;

[Table("USER_PLAYS_GAMES_JT")]
public class UserGame
{
    [Column("USER_ID")]
    public int UserId { get; set; }
    public User User { get; set; }
    
    [Column("GAME_ID")]
    public int GameId { get; set; }
    public Game Game { get; set; }
    
    [Column("FACTION_ID")]
    public int FactionId { get; set; }
    public Faction Faction { get; set; }
}