namespace Model.Entities.MonolithArena.GameContent;

[Table("FIELDS")]
public class Field
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public int X { get; set; }
    
    public int Y { get; set; }
    
    public int Z { get; set; }
}