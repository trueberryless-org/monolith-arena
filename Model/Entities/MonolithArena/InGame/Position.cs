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
    
    public List<TileField> Fields { get; set; }
    
    public List<GameLog> Logs { get; set; }
}