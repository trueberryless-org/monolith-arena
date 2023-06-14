using Model.Entities.MonolithArena.InGame.Logs;

namespace Model.Entities.MonolithArena.InGame;

[Table("GAMES")]
public class Game
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [NotMapped]
    public List<Position> Positions { get; set; }
    
    [NotMapped]
    public List<UserGame> Users { get; set; }
    
    [NotMapped]
    public List<GameLog> Logs { get; set; }
}