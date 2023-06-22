using Model.Entities.MonolithArena.Enums;

namespace Model.Entities.MonolithArena.GameContent;

[Table("BANNERS")]
public class Banner : Champion
{
    public BannerType BannerType { get; set; }

    public List<BannerDirection> Directions { get; set; }

    [Column("HEALTH")] 
    public int Health { get; set; } = 20;
}