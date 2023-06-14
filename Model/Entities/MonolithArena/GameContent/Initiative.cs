namespace Model.Entities.MonolithArena.GameContent;

[Table("INITIATIVES")]
public class Initiative
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public int Value { get; set; }
}