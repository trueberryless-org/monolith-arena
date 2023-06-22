using Model.Entities;
using Model.Entities.Authentication;
using Model.Entities.Log;
using Model.Entities.MonolithArena;
using Model.Entities.MonolithArena.Enums;
using Model.Entities.MonolithArena.GameContent;
using Model.Entities.MonolithArena.InGame;
using Position = Model.Entities.MonolithArena.InGame.Position;

namespace Model.Configuration;

public class ModelDbContext : DbContext
{
    public DbSet<Champion> Champions { get; set; }
    public DbSet<ChampionAttack> ChampionAttacks { get; set; }
    public DbSet<ChampionFeature> ChampionFeatures { get; set; }
    public DbSet<ChampionInitiative> ChampionInitiatives { get; set; }
    public DbSet<Faction> Factions { get; set; }
    public DbSet<Field> Fields { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Rune> Runes { get; set; }
    public DbSet<RuneDirection> RuneDirections { get; set; }
    public DbSet<RuneFeature> RuneFeatures { get; set; }
    public DbSet<Tile> Tiles { get; set; }

    public DbSet<Game> Games { get; set; }
    public DbSet<GameLog> GameLogs { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<TileField> TileFields { get; set; }
    public DbSet<UserGame> UserGames { get; set; }


    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RoleClaim> RoleClaims { get; set; }
    public DbSet<LogEntry> LogEntries { get; set; }

    public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Auto Includes

        modelBuilder.Entity<Game>()
            .Navigation(e => e.Users)
            .AutoInclude();

        modelBuilder.Entity<Game>()
            .Navigation(e => e.Positions)
            .AutoInclude();

        modelBuilder.Entity<Game>()
            .Navigation(e => e.Logs)
            .AutoInclude();

        modelBuilder.Entity<UserGame>()
            .Navigation(e => e.User)
            .AutoInclude();

        modelBuilder.Entity<UserGame>()
            .Navigation(e => e.Faction)
            .AutoInclude();

        modelBuilder.Entity<Position>()
            .Navigation(e => e.Fields)
            .AutoInclude();

        modelBuilder.Entity<Position>()
            .Navigation(e => e.Logs)
            .AutoInclude();

        modelBuilder.Entity<GameLog>()
            .Navigation(e => e.User)
            .AutoInclude();

        modelBuilder.Entity<GameLog>()
            .Navigation(e => e.Position)
            .AutoInclude();

        modelBuilder.Entity<GameLog>()
            .Navigation(e => e.Tile)
            .AutoInclude();

        modelBuilder.Entity<GameLog>()
            .Navigation(e => e.Field)
            .AutoInclude();

        modelBuilder.Entity<TileField>()
            .Navigation(e => e.Tile)
            .AutoInclude();

        modelBuilder.Entity<TileField>()
            .Navigation(e => e.Field)
            .AutoInclude();

        modelBuilder.Entity<Champion>()
            .Navigation(e => e.Attacks)
            .AutoInclude();

        modelBuilder.Entity<Champion>()
            .Navigation(e => e.Features)
            .AutoInclude();

        modelBuilder.Entity<Champion>()
            .Navigation(e => e.Initiatives)
            .AutoInclude();

        modelBuilder.Entity<Banner>()
            .Navigation(e => e.Directions)
            .AutoInclude();

        modelBuilder.Entity<Faction>()
            .Navigation(e => e.Tiles)
            .AutoInclude();

        modelBuilder.Entity<Rune>()
            .Navigation(e => e.Directions)
            .AutoInclude();

        modelBuilder.Entity<Rune>()
            .Navigation(e => e.Features)
            .AutoInclude();

        #endregion

        #region Enum Conversions

        modelBuilder.Entity<Banner>()
            .Property(e => e.BannerType)
            .HasConversion<string>();

        modelBuilder.Entity<BannerDirection>()
            .Property(e => e.Direction)
            .HasConversion<string>();

        modelBuilder.Entity<ChampionAttack>()
            .Property(e => e.Attack)
            .HasConversion<string>();

        modelBuilder.Entity<ChampionAttack>()
            .Property(e => e.Direction)
            .HasConversion<string>();

        modelBuilder.Entity<ChampionFeature>()
            .Property(e => e.Feature)
            .HasConversion<string>();

        modelBuilder.Entity<Faction>()
            .Property(e => e.Color)
            .HasConversion<string>();

        modelBuilder.Entity<Order>()
            .Property(e => e.OrderType)
            .HasConversion<string>();

        modelBuilder.Entity<Rune>()
            .Property(e => e.RuneType)
            .HasConversion<string>();

        modelBuilder.Entity<RuneDirection>()
            .Property(e => e.Direction)
            .HasConversion<string>();

        modelBuilder.Entity<RuneFeature>()
            .Property(e => e.Feature)
            .HasConversion<string>();

        modelBuilder.Entity<GameLog>()
            .Property(e => e.Direction)
            .HasConversion<string>();

        modelBuilder.Entity<GameLog>()
            .Property(e => e.LogType)
            .HasConversion<string>();

        modelBuilder.Entity<TileField>()
            .Property(e => e.Direction)
            .HasConversion<string>();

        modelBuilder.Entity<LogEntry>()
            .Property(le => le.FieldType)
            .HasConversion<string>();

        #endregion

        #region IsUnique

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.Entity<Role>()
            .HasIndex(r => r.Identifier)
            .IsUnique();

        #endregion

        #region Composite Key

        modelBuilder.Entity<TileField>()
            .HasKey(e => new { e.FieldId, e.TileId, e.PositionId });

        modelBuilder.Entity<UserGame>()
            .HasKey(e => new { e.UserId, e.GameId });

        modelBuilder.Entity<RoleClaim>()
            .HasKey(rc => new { rc.UserId, rc.RoleId });

        #endregion

        #region Relationships

        modelBuilder.Entity<ChampionAttack>()
            .HasOne(e => e.Champion)
            .WithMany(e => e.Attacks)
            .HasForeignKey(e => e.ChampionId);

        modelBuilder.Entity<ChampionFeature>()
            .HasOne(e => e.Champion)
            .WithMany(e => e.Features)
            .HasForeignKey(e => e.ChampionId);

        modelBuilder.Entity<ChampionInitiative>()
            .HasOne(e => e.Champion)
            .WithMany(e => e.Initiatives)
            .HasForeignKey(e => e.ChampionId);

        modelBuilder.Entity<BannerDirection>()
            .HasOne(e => e.Banner)
            .WithMany(e => e.Directions)
            .HasForeignKey(e => e.BannerId);

        modelBuilder.Entity<RuneDirection>()
            .HasOne(e => e.Rune)
            .WithMany(e => e.Directions)
            .HasForeignKey(e => e.RuneId);

        modelBuilder.Entity<RuneFeature>()
            .HasOne(e => e.Rune)
            .WithMany(e => e.Features)
            .HasForeignKey(e => e.RuneId);

        modelBuilder.Entity<Tile>()
            .HasOne(e => e.Faction)
            .WithMany(e => e.Tiles)
            .HasForeignKey(e => e.FactionId);

        modelBuilder.Entity<GameLog>()
            .HasOne(e => e.Game)
            .WithMany(e => e.Logs)
            .HasForeignKey(e => e.GameId);

        modelBuilder.Entity<GameLog>()
            .HasOne(e => e.Position)
            .WithMany(e => e.Logs)
            .HasForeignKey(e => e.PositionId);

        modelBuilder.Entity<GameLog>()
            .HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId);

        modelBuilder.Entity<TileField>()
            .HasOne(e => e.Field)
            .WithMany()
            .HasForeignKey(e => e.FieldId);

        modelBuilder.Entity<TileField>()
            .HasOne(e => e.Tile)
            .WithMany()
            .HasForeignKey(e => e.TileId);

        modelBuilder.Entity<TileField>()
            .HasOne(e => e.Position)
            .WithMany(e => e.Fields)
            .HasForeignKey(e => e.PositionId);

        modelBuilder.Entity<Position>()
            .HasOne(e => e.Game)
            .WithMany(e => e.Positions)
            .HasForeignKey(e => e.GameId);

        modelBuilder.Entity<UserGame>()
            .HasOne(e => e.User)
            .WithMany(e => e.Games)
            .HasForeignKey(e => e.UserId);

        modelBuilder.Entity<UserGame>()
            .HasOne(e => e.Game)
            .WithMany(e => e.Users)
            .HasForeignKey(e => e.GameId);

        modelBuilder.Entity<UserGame>()
            .HasOne(e => e.Faction)
            .WithMany()
            .HasForeignKey(e => e.FactionId);

        modelBuilder.Entity<RoleClaim>()
            .HasOne(rc => rc.Role)
            .WithMany(r => r.RoleClaims)
            .HasForeignKey(rc => rc.RoleId);

        modelBuilder.Entity<RoleClaim>()
            .HasOne(rc => rc.User)
            .WithMany(u => u.RoleClaims)
            .HasForeignKey(rc => rc.UserId);

        modelBuilder.Entity<LogEntry>()
            .HasOne(le => le.User)
            .WithMany()
            .HasForeignKey(le => le.UserId);

        #endregion

        #region Data

        modelBuilder.Entity<Role>()
            .HasData(new Role { Id = 1, Identifier = "Admin", Description = "Administrator" });

        modelBuilder.Entity<Faction>()
            .HasData(
                new Faction() { Id = 1, Name = "Dragon Empire", Color = FactionColor.BLUE },
                new Faction() { Id = 2, Name = "Lord of the Abyss", Color = FactionColor.RED },
                new Faction() { Id = 3, Name = "Guardians of the Realm", Color = FactionColor.ORANGE },
                new Faction() { Id = 4, Name = "Harbingers of the Forest", Color = FactionColor.GREEN });

        modelBuilder.Entity<Banner>()
            .HasData(
                new Banner()
                {
                    Id = 101, Name = "Banner", Quantity = 1, Health = 20, BannerType = BannerType.STRENGTH,
                    FactionId = 1
                },
                new Banner()
                {
                    Id = 201, Name = "Banner", Quantity = 1, Health = 20, BannerType = BannerType.VENOM, FactionId = 2
                },
                new Banner()
                {
                    Id = 301, Name = "Banner", Quantity = 1, Health = 20, BannerType = BannerType.TOUGHNESS,
                    FactionId = 3
                },
                new Banner()
                {
                    Id = 401, Name = "Banner", Quantity = 1, Health = 20, BannerType = BannerType.MANEUVER,
                    FactionId = 4
                });


        #region Dragon Empire

        modelBuilder.Entity<Champion>()
            .HasData(
                new Champion() { Id = 102, Name = "Pikeman", Quantity = 3, FactionId = 1 },
                new Champion() { Id = 103, Name = "Knight", Quantity = 4, FactionId = 1 },
                new Champion() { Id = 104, Name = "Dragon Rider", Quantity = 1, FactionId = 1 },
                new Champion() { Id = 105, Name = "Swordsman", Quantity = 2, FactionId = 1 },
                new Champion() { Id = 106, Name = "Landsknecht", Quantity = 1, FactionId = 1 },
                new Champion() { Id = 107, Name = "Arquebusier", Quantity = 2, FactionId = 1 });

        modelBuilder.Entity<ChampionInitiative>()
            .HasData(
                new ChampionInitiative() { Id = 101, ChampionId = 101, Initiative = 0 },
                new ChampionInitiative() { Id = 102, ChampionId = 102, Initiative = 2 },
                new ChampionInitiative() { Id = 103, ChampionId = 103, Initiative = 1 },
                new ChampionInitiative() { Id = 104, ChampionId = 104, Initiative = 2 },
                new ChampionInitiative() { Id = 105, ChampionId = 105, Initiative = 3 },
                new ChampionInitiative() { Id = 106, ChampionId = 106, Initiative = 2 },
                new ChampionInitiative() { Id = 107, ChampionId = 107, Initiative = 2 });

        modelBuilder.Entity<ChampionAttack>()
            .HasData(
                new ChampionAttack()
                {
                    Id = 101, ChampionId = 101, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 102, ChampionId = 101, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 103, ChampionId = 101, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 104, ChampionId = 101, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 105, ChampionId = 101, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 106, ChampionId = 101, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 107, ChampionId = 102, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 108, ChampionId = 102, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 109, ChampionId = 102, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 110, ChampionId = 102, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 111, ChampionId = 103, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 2
                },
                new ChampionAttack()
                {
                    Id = 112, ChampionId = 103, Attack = AttackType.ARMOR, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 113, ChampionId = 103, Attack = AttackType.ARMOR, Direction = DirectionType.WEST, Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 114, ChampionId = 103, Attack = AttackType.ARMOR, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 115, ChampionId = 104, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 3
                },
                new ChampionAttack()
                {
                    Id = 116, ChampionId = 104, Attack = AttackType.ARMOR, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 117, ChampionId = 104, Attack = AttackType.ARMOR, Direction = DirectionType.WEST, Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 118, ChampionId = 104, Attack = AttackType.ARMOR, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 119, ChampionId = 105, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 120, ChampionId = 105, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 121, ChampionId = 106, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 2
                },
                new ChampionAttack()
                {
                    Id = 122, ChampionId = 106, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 123, ChampionId = 106, Attack = AttackType.ARMOR, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 124, ChampionId = 106, Attack = AttackType.ARMOR, Direction = DirectionType.EAST, Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 125, ChampionId = 107, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 126,
                    ChampionId = 107, Attack = AttackType.ARMOR, Direction = DirectionType.NORTH_WEST, Strength = 1
                });

        modelBuilder.Entity<ChampionFeature>()
            .HasData(
                new ChampionFeature() { Id = 101, ChampionId = 103, Feature = FeatureType.TOUGHNESS },
                new ChampionFeature() { Id = 102, ChampionId = 103, Feature = FeatureType.MANEUVER },
                new ChampionFeature() { Id = 103, ChampionId = 103, Feature = FeatureType.CAVALRY },
                new ChampionFeature() { Id = 104, ChampionId = 104, Feature = FeatureType.MANEUVER },
                new ChampionFeature() { Id = 105, ChampionId = 104, Feature = FeatureType.CAVALRY });

        modelBuilder.Entity<Rune>()
            .HasData(
                new Rune() { Id = 108, RuneType = RuneType.MINOR_ACCELERATION, Quantity = 2, FactionId = 1 },
                new Rune() { Id = 109, RuneType = RuneType.REGENERATION, Quantity = 3, FactionId = 1 },
                new Rune() { Id = 110, RuneType = RuneType.AGILITY, Quantity = 1, FactionId = 1 },
                new Rune() { Id = 111, RuneType = RuneType.STRENGTH, Quantity = 2, FactionId = 1 },
                new Rune() { Id = 112, RuneType = RuneType.CHARGE, Quantity = 1, FactionId = 1 });

        modelBuilder.Entity<RuneDirection>()
            .HasData(
                new RuneDirection() { Id = 101, RuneId = 108, Direction = DirectionType.NORTH_EAST },
                new RuneDirection() { Id = 102, RuneId = 108, Direction = DirectionType.EAST },
                new RuneDirection() { Id = 103, RuneId = 108, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 104, RuneId = 108, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 105, RuneId = 108, Direction = DirectionType.WEST },
                new RuneDirection() { Id = 106, RuneId = 108, Direction = DirectionType.NORTH_WEST },
                new RuneDirection() { Id = 107, RuneId = 109, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 108, RuneId = 109, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 109, RuneId = 110, Direction = DirectionType.NORTH_EAST },
                new RuneDirection() { Id = 110, RuneId = 110, Direction = DirectionType.EAST },
                new RuneDirection() { Id = 111, RuneId = 110, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 112, RuneId = 110, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 113, RuneId = 110, Direction = DirectionType.WEST },
                new RuneDirection() { Id = 114, RuneId = 110, Direction = DirectionType.NORTH_WEST },
                new RuneDirection() { Id = 115, RuneId = 111, Direction = DirectionType.EAST },
                new RuneDirection() { Id = 116, RuneId = 111, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 117, RuneId = 111, Direction = DirectionType.SOUTH_WEST });

        modelBuilder.Entity<RuneFeature>()
            .HasData(
                new RuneFeature() { Id = 101, RuneId = 112, Feature = FeatureType.BOUNDLESS });

        modelBuilder.Entity<Order>()
            .HasData(
                new Order() { Id = 113, OrderType = OrderType.BATTLE_OR_CHARGE, Quantity = 7, FactionId = 1 },
                new Order() { Id = 114, OrderType = OrderType.MOVE, Quantity = 4, FactionId = 1 },
                new Order() { Id = 115, OrderType = OrderType.NET, Quantity = 1, FactionId = 1 });

        #endregion

        #region Lord of the Abyss

        modelBuilder.Entity<Champion>()
            .HasData(
                new Champion() { Id = 202, Name = "Mygalomorph", Quantity = 3, FactionId = 2 },
                new Champion() { Id = 203, Name = "Spike", Quantity = 3, FactionId = 2 },
                new Champion() { Id = 204, Name = "Chaos", Quantity = 2, FactionId = 2 },
                new Champion() { Id = 205, Name = "Horror", Quantity = 2, FactionId = 2 },
                new Champion() { Id = 206, Name = "Nightmare", Quantity = 1, FactionId = 2 },
                new Champion() { Id = 207, Name = "Wraith", Quantity = 2, FactionId = 2 },
                new Champion() { Id = 208, Name = "Demon", Quantity = 1, FactionId = 2 });

        modelBuilder.Entity<ChampionInitiative>()
            .HasData(
                new ChampionInitiative() { Id = 201, ChampionId = 201, Initiative = 0 },
                new ChampionInitiative() { Id = 202, ChampionId = 202, Initiative = 3 },
                new ChampionInitiative() { Id = 203, ChampionId = 203, Initiative = 1 },
                new ChampionInitiative() { Id = 204, ChampionId = 204, Initiative = 2 },
                new ChampionInitiative() { Id = 205, ChampionId = 205, Initiative = 0 },
                new ChampionInitiative() { Id = 206, ChampionId = 207, Initiative = 2 },
                new ChampionInitiative() { Id = 207, ChampionId = 208, Initiative = 1 });

        modelBuilder.Entity<ChampionAttack>()
            .HasData(
                new ChampionAttack()
                {
                    Id = 201, ChampionId = 201, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 202, ChampionId = 201, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 203, ChampionId = 201, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 204, ChampionId = 201, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 205, ChampionId = 201, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 206, ChampionId = 201, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 207, ChampionId = 202, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 208, ChampionId = 202, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 209, ChampionId = 202, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 210, ChampionId = 203, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 211, ChampionId = 204, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 2
                },
                new ChampionAttack()
                {
                    Id = 212, ChampionId = 204, Attack = AttackType.ARMOR, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 213, ChampionId = 204, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 214, ChampionId = 205, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 2
                },
                new ChampionAttack()
                {
                    Id = 215, ChampionId = 205, Attack = AttackType.NET, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 216, ChampionId = 206, Attack = AttackType.NET, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 217, ChampionId = 207, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 218, ChampionId = 207, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 219, ChampionId = 208, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 2
                },
                new ChampionAttack()
                {
                    Id = 220, ChampionId = 208, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 2
                },
                new ChampionAttack()
                {
                    Id = 221, ChampionId = 208, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 2
                });

        modelBuilder.Entity<ChampionFeature>()
            .HasData(
                new ChampionFeature() { Id = 201, ChampionId = 202, Feature = FeatureType.VENOM },
                new ChampionFeature() { Id = 202, ChampionId = 206, Feature = FeatureType.TELEPORT },
                new ChampionFeature() { Id = 203, ChampionId = 207, Feature = FeatureType.MANEUVER },
                new ChampionFeature() { Id = 204, ChampionId = 208, Feature = FeatureType.TRANSFORMATION });

        modelBuilder.Entity<Rune>()
            .HasData(
                new Rune() { Id = 209, RuneType = RuneType.DISARMAMENT, Quantity = 2, FactionId = 2 },
                new Rune() { Id = 210, RuneType = RuneType.MINOR_ACCELERATION, Quantity = 2, FactionId = 2 },
                new Rune() { Id = 211, RuneType = RuneType.TELEPORTATION, Quantity = 2, FactionId = 2 },
                new Rune() { Id = 212, RuneType = RuneType.STRENGTH, Quantity = 2, FactionId = 2 },
                new Rune() { Id = 213, RuneType = RuneType.REGENERATION, Quantity = 1, FactionId = 2 },
                new Rune() { Id = 214, RuneType = RuneType.DOUBLE_ATTACK, Quantity = 1, FactionId = 2 });

        modelBuilder.Entity<RuneDirection>()
            .HasData(
                new RuneDirection() { Id = 201, RuneId = 209, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 202, RuneId = 209, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 203, RuneId = 210, Direction = DirectionType.EAST },
                new RuneDirection() { Id = 204, RuneId = 210, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 205, RuneId = 210, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 206, RuneId = 210, Direction = DirectionType.NORTH_WEST },
                new RuneDirection() { Id = 207, RuneId = 211, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 208, RuneId = 212, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 209, RuneId = 212, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 210, RuneId = 213, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 211, RuneId = 214, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 212, RuneId = 214, Direction = DirectionType.SOUTH_WEST });

        modelBuilder.Entity<RuneFeature>()
            .HasData(
                new RuneFeature() { Id = 201, RuneId = 212, Feature = FeatureType.TOUGHNESS });

        modelBuilder.Entity<Order>()
            .HasData(
                new Order() { Id = 215, OrderType = OrderType.BATTLE, Quantity = 6, FactionId = 2 },
                new Order() { Id = 216, OrderType = OrderType.MOVE, Quantity = 2, FactionId = 2 },
                new Order() { Id = 217, OrderType = OrderType.PUSH, Quantity = 2, FactionId = 2 });

        #endregion

        #region Guardians of the Realm

        modelBuilder.Entity<Champion>()
            .HasData(
                new Champion() { Id = 302, Name = "Axeman", Quantity = 3, FactionId = 3 },
                new Champion() { Id = 303, Name = "Crossbowman", Quantity = 3, FactionId = 3 },
                new Champion() { Id = 304, Name = "Veteran", Quantity = 2, FactionId = 3 },
                new Champion() { Id = 305, Name = "Golem", Quantity = 2, FactionId = 3 },
                new Champion() { Id = 306, Name = "Combat Platform", Quantity = 1, FactionId = 3 },
                new Champion() { Id = 307, Name = "Pupil", Quantity = 1, FactionId = 3 },
                new Champion() { Id = 308, Name = "Wyvern", Quantity = 1, FactionId = 3 });

        modelBuilder.Entity<ChampionInitiative>()
            .HasData(
                new ChampionInitiative() { Id = 301, ChampionId = 301, Initiative = 0 },
                new ChampionInitiative() { Id = 302, ChampionId = 302, Initiative = 2 },
                new ChampionInitiative() { Id = 303, ChampionId = 302, Initiative = 1 },
                new ChampionInitiative() { Id = 304, ChampionId = 303, Initiative = 2 },
                new ChampionInitiative() { Id = 305, ChampionId = 304, Initiative = 2 },
                new ChampionInitiative() { Id = 306, ChampionId = 306, Initiative = 3 },
                new ChampionInitiative() { Id = 307, ChampionId = 307, Initiative = 3 },
                new ChampionInitiative() { Id = 308, ChampionId = 308, Initiative = 2 });

        modelBuilder.Entity<ChampionAttack>()
            .HasData(
                new ChampionAttack()
                {
                    Id = 301, ChampionId = 301, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 302, ChampionId = 301, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 303, ChampionId = 301, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 304, ChampionId = 301, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 305, ChampionId = 301, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 306, ChampionId = 301, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 307, ChampionId = 302, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 308, ChampionId = 302, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 309, ChampionId = 302, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 310, ChampionId = 303, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 311, ChampionId = 303, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 312, ChampionId = 304, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 313, ChampionId = 304, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 2
                },
                new ChampionAttack()
                {
                    Id = 314, ChampionId = 304, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 315, ChampionId = 304, Attack = AttackType.ARMOR, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 316, ChampionId = 305, Attack = AttackType.ARMOR, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 317, ChampionId = 306, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.SOUTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 318, ChampionId = 306, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 319, ChampionId = 306, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 320, ChampionId = 306, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 321, ChampionId = 307, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 322, ChampionId = 308, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 323, ChampionId = 308, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 324, ChampionId = 308, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 325, ChampionId = 308, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 326, ChampionId = 308, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 2
                },
                new ChampionAttack()
                {
                    Id = 327, ChampionId = 308, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                });

        modelBuilder.Entity<ChampionFeature>()
            .HasData(
                new ChampionFeature() { Id = 301, ChampionId = 303, Feature = FeatureType.TOUGHNESS },
                new ChampionFeature() { Id = 302, ChampionId = 305, Feature = FeatureType.MANEUVER, Quantity = 2 },
                new ChampionFeature() { Id = 303, ChampionId = 307, Feature = FeatureType.MANEUVER },
                new ChampionFeature() { Id = 304, ChampionId = 308, Feature = FeatureType.TOUGHNESS });

        modelBuilder.Entity<Rune>()
            .HasData(
                new Rune() { Id = 309, RuneType = RuneType.AGILITY, Quantity = 1, FactionId = 3 },
                new Rune() { Id = 310, RuneType = RuneType.REINFORCEMENT, Quantity = 2, FactionId = 3 },
                new Rune() { Id = 311, RuneType = RuneType.DOUBLE_ATTACK, Quantity = 1, FactionId = 3 },
                new Rune() { Id = 312, RuneType = RuneType.REGENERATION, Quantity = 2, FactionId = 3 },
                new Rune() { Id = 313, RuneType = RuneType.PENETRATION, Quantity = 1, FactionId = 3 });

        modelBuilder.Entity<RuneDirection>()
            .HasData(
                new RuneDirection() { Id = 301, RuneId = 309, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 302, RuneId = 309, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 303, RuneId = 310, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 304, RuneId = 310, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 305, RuneId = 310, Direction = DirectionType.WEST },
                new RuneDirection() { Id = 306, RuneId = 311, Direction = DirectionType.NORTH_EAST },
                new RuneDirection() { Id = 307, RuneId = 311, Direction = DirectionType.EAST },
                new RuneDirection() { Id = 308, RuneId = 311, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 309, RuneId = 311, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 310, RuneId = 311, Direction = DirectionType.WEST },
                new RuneDirection() { Id = 311, RuneId = 311, Direction = DirectionType.NORTH_WEST },
                new RuneDirection() { Id = 312, RuneId = 312, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 313, RuneId = 312, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 314, RuneId = 313, Direction = DirectionType.SOUTH_EAST });

        modelBuilder.Entity<RuneFeature>()
            .HasData(
                new RuneFeature() { Id = 301, RuneId = 309, Feature = FeatureType.ROTATION });

        modelBuilder.Entity<Order>()
            .HasData(
                new Order() { Id = 314, OrderType = OrderType.BATTLE, Quantity = 5, FactionId = 3 },
                new Order() { Id = 315, OrderType = OrderType.PUSH, Quantity = 3, FactionId = 3 },
                new Order() { Id = 316, OrderType = OrderType.FIRE_CONCOCTION, Quantity = 2, FactionId = 3 },
                new Order() { Id = 317, OrderType = OrderType.ENTRENCHMENT, Quantity = 1, FactionId = 3 },
                new Order() { Id = 318, OrderType = OrderType.ROTATION, Quantity = 2, FactionId = 3 },
                new Order() { Id = 319, OrderType = OrderType.FALSE_ORDER, Quantity = 1, FactionId = 3 });

        #endregion

        #region Harbingers of the Forest

        modelBuilder.Entity<Champion>()
            .HasData(
                new Champion() { Id = 402, Name = "Morlock", Quantity = 2, FactionId = 4 },
                new Champion() { Id = 403, Name = "Spark", Quantity = 4, FactionId = 4 },
                new Champion() { Id = 404, Name = "Hunter", Quantity = 2, FactionId = 4 },
                new Champion() { Id = 405, Name = "Sorcerer", Quantity = 1, FactionId = 4 },
                new Champion() { Id = 406, Name = "Herne", Quantity = 2, FactionId = 4 },
                new Champion() { Id = 407, Name = "Assassin", Quantity = 3, FactionId = 4 },
                new Champion() { Id = 408, Name = "Wyrm", Quantity = 1, FactionId = 4 });

        modelBuilder.Entity<ChampionInitiative>()
            .HasData(
                new ChampionInitiative() { Id = 401, ChampionId = 401, Initiative = 0 },
                new ChampionInitiative() { Id = 402, ChampionId = 402, Initiative = -1 },
                new ChampionInitiative() { Id = 403, ChampionId = 403, Initiative = 2 },
                new ChampionInitiative() { Id = 404, ChampionId = 404, Initiative = 3 },
                new ChampionInitiative() { Id = 405, ChampionId = 404, Initiative = 0 },
                new ChampionInitiative() { Id = 406, ChampionId = 405, Initiative = 2 },
                new ChampionInitiative() { Id = 407, ChampionId = 406, Initiative = 2 },
                new ChampionInitiative() { Id = 408, ChampionId = 407, Initiative = 3 },
                new ChampionInitiative() { Id = 409, ChampionId = 408, Initiative = 2 },
                new ChampionInitiative() { Id = 410, ChampionId = 408, Initiative = 1 });

        modelBuilder.Entity<ChampionAttack>()
            .HasData(
                new ChampionAttack()
                {
                    Id = 401, ChampionId = 401, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 402, ChampionId = 401, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 403, ChampionId = 401, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 404, ChampionId = 401, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 405, ChampionId = 401, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 406, ChampionId = 401, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 407, ChampionId = 402, Attack = AttackType.KILL_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 408, ChampionId = 403, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 409, ChampionId = 403, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 410, ChampionId = 404, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 411, ChampionId = 405, Attack = AttackType.RANGED_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 2
                },
                new ChampionAttack()
                {
                    Id = 412, ChampionId = 406, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 2
                },
                new ChampionAttack()
                {
                    Id = 413, ChampionId = 407, Attack = AttackType.MELEE_ATTACK,
                    Direction = DirectionType.ENTIRE_BOARD, Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 414, ChampionId = 408, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 415, ChampionId = 408, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 416, ChampionId = 408, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_EAST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 417, ChampionId = 408, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.SOUTH_WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 418, ChampionId = 408, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.WEST,
                    Strength = 1
                },
                new ChampionAttack()
                {
                    Id = 419, ChampionId = 408, Attack = AttackType.MELEE_ATTACK, Direction = DirectionType.NORTH_WEST,
                    Strength = 1
                });

        modelBuilder.Entity<ChampionFeature>()
            .HasData(
                new ChampionFeature() { Id = 401, ChampionId = 406, Feature = FeatureType.MANEUVER },
                new ChampionFeature() { Id = 402, ChampionId = 407, Feature = FeatureType.INFINITY_ATTACK },
                new ChampionFeature() { Id = 403, ChampionId = 408, Feature = FeatureType.MANEUVER });

        modelBuilder.Entity<Rune>()
            .HasData(
                new Rune() { Id = 409, RuneType = RuneType.MINOR_ACCELERATION, Quantity = 3, FactionId = 4 },
                new Rune() { Id = 410, RuneType = RuneType.GREATER_ACCELERATION, Quantity = 1, FactionId = 4 },
                new Rune() { Id = 411, RuneType = RuneType.REGENERATION, Quantity = 2, FactionId = 4 },
                new Rune() { Id = 412, RuneType = RuneType.ACCURACY, Quantity = 1, FactionId = 4 },
                new Rune() { Id = 413, RuneType = RuneType.DOUBLE_ATTACK, Quantity = 1, FactionId = 4 });

        modelBuilder.Entity<RuneDirection>()
            .HasData(
                new RuneDirection() { Id = 401, RuneId = 409, Direction = DirectionType.NORTH_EAST },
                new RuneDirection() { Id = 402, RuneId = 409, Direction = DirectionType.EAST },
                new RuneDirection() { Id = 403, RuneId = 409, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 404, RuneId = 409, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 405, RuneId = 409, Direction = DirectionType.WEST },
                new RuneDirection() { Id = 406, RuneId = 409, Direction = DirectionType.NORTH_WEST },
                new RuneDirection() { Id = 407, RuneId = 410, Direction = DirectionType.EAST },
                new RuneDirection() { Id = 408, RuneId = 410, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 409, RuneId = 410, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 410, RuneId = 411, Direction = DirectionType.NORTH_EAST },
                new RuneDirection() { Id = 411, RuneId = 411, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 412, RuneId = 412, Direction = DirectionType.NORTH_EAST },
                new RuneDirection() { Id = 413, RuneId = 412, Direction = DirectionType.EAST },
                new RuneDirection() { Id = 414, RuneId = 412, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 415, RuneId = 412, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 416, RuneId = 412, Direction = DirectionType.WEST },
                new RuneDirection() { Id = 417, RuneId = 412, Direction = DirectionType.NORTH_WEST },
                new RuneDirection() { Id = 418, RuneId = 413, Direction = DirectionType.NORTH_EAST },
                new RuneDirection() { Id = 419, RuneId = 413, Direction = DirectionType.EAST },
                new RuneDirection() { Id = 420, RuneId = 413, Direction = DirectionType.SOUTH_EAST },
                new RuneDirection() { Id = 421, RuneId = 413, Direction = DirectionType.SOUTH_WEST },
                new RuneDirection() { Id = 422, RuneId = 413, Direction = DirectionType.WEST },
                new RuneDirection() { Id = 423, RuneId = 413, Direction = DirectionType.NORTH_WEST });

        modelBuilder.Entity<Order>()
            .HasData(
                new Order() { Id = 414, OrderType = OrderType.BATTLE, Quantity = 6, FactionId = 4 },
                new Order() { Id = 415, OrderType = OrderType.MOVE, Quantity = 4, FactionId = 4 },
                new Order() { Id = 416, OrderType = OrderType.PRECISE_SHOT, Quantity = 1, FactionId = 4 });

        #endregion

        #endregion
    }
}