namespace Model.Entities.MonolithArena;

[Table("INITIATIVES")]
public class Initiative
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public int Value { get; set; }
}