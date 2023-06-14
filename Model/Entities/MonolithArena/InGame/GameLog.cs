using Model.Entities.Authentication;

namespace Model.Entities.MonolithArena.InGame;

[Table("GAME_LOGS_BT")]
public class GameLog
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("GAME_ID")]
    public int GameId { get; set; }
    public Game Game { get; set; }
    
    [Column("POSITION_ID")]
    public int PositionId { get; set; }
    public Position Position { get; set; }
    
    [Column("USER_ID")]
    public int UserId { get; set; }
    public User User { get; set; }
    
}