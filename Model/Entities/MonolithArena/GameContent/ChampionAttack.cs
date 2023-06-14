namespace Model.Entities.MonolithArena.GameContent;

[Table("CHAMPION_HAS_ATTACKS_JT")]
public class ChampionAttack
{
    [Column("CHAMPION_ID")]
    public int ChampionId { get; set; }
    public Champion Champion { get; set; }
    
    [Column("ATTACK_ID")]
    public int AttackId { get; set; }
    public Attack Attack { get; set; }
    
    [Column("DIRECTION_ID")]
    public int DirectionId { get; set; }
    public Direction Direction { get; set; }

    public int Strength { get; set; } = 1;
}