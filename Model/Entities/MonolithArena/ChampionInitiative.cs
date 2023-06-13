namespace Model.Entities.MonolithArena;

[Table("CHAMPION_HAS_INITIATIVES_JT")]
public class ChampionInitiative
{
    [Column("CHAMPION_ID")]
    public int ChampionId { get; set; }
    public Champion Champion { get; set; }
    
    [Column("INITIATIVE_ID")]
    public int InitiativeId { get; set; }
    public Initiative Initiative { get; set; }
}