namespace Model.Entities.MonolithArena.InGame;

[Table("GAMES")]
public class Game
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public List<Position> Positions { get; set; }
    
    public List<UserGame> Users { get; set; }
    
    public List<GameLog> Logs { get; set; }
}