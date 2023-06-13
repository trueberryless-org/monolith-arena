namespace Model.Entities.MonolithArena;

[Table("ATTACKS")]
public class Attack
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public AttackType AttackType { get; set; }
}