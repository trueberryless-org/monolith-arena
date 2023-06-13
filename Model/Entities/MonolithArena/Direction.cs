namespace Model.Entities.MonolithArena;

[Table("DIRECTIONS")]
public class Direction
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public DirectionType DirectionType { get; set; }
}