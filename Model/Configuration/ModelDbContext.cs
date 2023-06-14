using Model.Entities;
using Model.Entities.Authentication;
using Model.Entities.Log;
using Model.Entities.MonolithArena;
using Model.Entities.MonolithArena.GameContent;
using Model.Entities.MonolithArena.InGame;
using Model.Entities.MonolithArena.InGame.Logs;
using Model.Entities.MonolithArena.InGame.Logs.TileLogs;
using Model.Entities.MonolithArena.InGame.Logs.TileLogs.TileFieldLogs;
using Model.Entities.MonolithArena.InGame.Logs.TileLogs.TileFieldLogs.TileFieldDirectionLogs;
using Direction = Model.Entities.MonolithArena.GameContent.Direction;
using Position = Model.Entities.MonolithArena.InGame.Position;

namespace Model.Configuration;

public class ModelDbContext : DbContext
{
    public DbSet<Attack> Attacks { get; set; }
    public DbSet<Champion> Champions { get; set; }
    public DbSet<ChampionAttack> ChampionAttacks { get; set; }
    public DbSet<ChampionFeature> ChampionFeatures { get; set; }
    public DbSet<ChampionInitiative> ChampionInitiatives { get; set; }
    public DbSet<Direction> Directions { get; set; }
    public DbSet<Faction> Factions { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Field> Fields { get; set; }
    public DbSet<Initiative> Initiatives { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Command> Commands { get; set; }
    public DbSet<LogicGate> LogicGates { get; set; }
    public DbSet<Rune> Runes { get; set; }
    public DbSet<RuneDirection> RuneDirections { get; set; }
    public DbSet<RuneFeature> RuneFeatures { get; set; }
    public DbSet<Tile> Tiles { get; set; }
    
    public DbSet<Game> Games { get; set; }
    public DbSet<GameLog> GameLogs { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<TileField> TileFields { get; set; }
    public DbSet<UserGame> UserGames { get; set; }
    public DbSet<BattleStart> BattleStarts { get; set; }
    public DbSet<TileLog> TileLogs { get; set; }
    public DbSet<TileDiscard> TileDiscards { get; set; }
    public DbSet<TileDraw> TileDraws { get; set; }
    public DbSet<TileManaCharge> TileManaCharges { get; set; }
    public DbSet<TileNet> TileNets { get; set; }
    public DbSet<TilePreciseShot> TilePreciseShots { get; set; }
    public DbSet<TileStorage> TileStorages { get; set; }
    public DbSet<TileFieldLog> TileFieldLogs { get; set; }
    public DbSet<TilePush> TilePushes { get; set; }
    public DbSet<TileFieldDirectionLog> TileFieldDirectionLogs { get; set; }
    public DbSet<TileCharge> TileCharges { get; set; }
    public DbSet<TileFalseOrder> TileFalseOrders { get; set; }
    public DbSet<TileMovement> TileMovements { get; set; }
    public DbSet<TilePlacement> TilePlacements { get; set; }
    
    
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RoleClaim> RoleClaims { get; set; }
    public DbSet<LogEntry> LogEntries { get; set; }
    
    public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // MONOLITH ARENA
        modelBuilder.Entity<Attack>()
            .Property(e => e.AttackType)
            .HasConversion<string>();
        
        modelBuilder.Entity<Champion>()
            .Property(e => e.ChampionType)
            .HasConversion<string>();

        modelBuilder.Entity<ChampionAttack>()
            .HasKey(e => new { e.ChampionId, e.AttackId, e.DirectionId });

        modelBuilder.Entity<ChampionAttack>()
            .HasOne(e => e.Champion)
            .WithMany(e => e.Attacks)
            .HasForeignKey(e => e.ChampionId);
        
        modelBuilder.Entity<ChampionAttack>()
            .HasOne(e => e.Attack)
            .WithMany()
            .HasForeignKey(e => e.AttackId);
        
        modelBuilder.Entity<ChampionAttack>()
            .HasOne(e => e.Direction)
            .WithMany()
            .HasForeignKey(e => e.DirectionId);

        modelBuilder.Entity<ChampionFeature>()
            .HasKey(e => new { e.ChampionId, e.FeatureId });

        modelBuilder.Entity<ChampionFeature>()
            .HasOne(e => e.Champion)
            .WithMany(e => e.Features)
            .HasForeignKey(e => e.ChampionId);

        modelBuilder.Entity<ChampionFeature>()
            .HasOne(e => e.Feature)
            .WithMany()
            .HasForeignKey(e => e.FeatureId);
        
        modelBuilder.Entity<ChampionInitiative>()
            .HasKey(e => new { e.ChampionId, e.InitiativeId });

        modelBuilder.Entity<ChampionInitiative>()
            .HasOne(e => e.Champion)
            .WithMany(e => e.Initiatives)
            .HasForeignKey(e => e.ChampionId);
        
        modelBuilder.Entity<ChampionInitiative>()
            .HasOne(e => e.Initiative)
            .WithMany()
            .HasForeignKey(e => e.InitiativeId);
        
        modelBuilder.Entity<Direction>()
            .Property(e => e.DirectionType)
            .HasConversion<string>();
        
        modelBuilder.Entity<Faction>()
            .Property(e => e.Color)
            .HasConversion<string>();

        modelBuilder.Entity<Feature>()
            .Property(e => e.FeatureType)
            .HasConversion<string>();

        modelBuilder.Entity<LogicGate>()
            .Property(e => e.LogicGateType)
            .HasConversion<string>();
        
        modelBuilder.Entity<LogicGate>()
            .HasOne(e => e.OptionOneOrder)
            .WithOne()
            .HasForeignKey<LogicGate>(e => e.OptionOneOrderId);

        modelBuilder.Entity<LogicGate>()
            .HasOne(e => e.OptionTwoOrder)
            .WithOne()
            .HasForeignKey<LogicGate>(e => e.OptionTwoOrderId);
        
        modelBuilder.Entity<Command>()
            .Property(e => e.OrderType)
            .HasConversion<string>();
        
        modelBuilder.Entity<Rune>()
            .Property(e => e.RuneType)
            .HasConversion<string>();
        
        modelBuilder.Entity<RuneDirection>()
            .HasKey(e => new { e.RuneId, e.DirectionId });

        modelBuilder.Entity<RuneDirection>()
            .HasOne(e => e.Rune)
            .WithMany(e => e.Directions)
            .HasForeignKey(e => e.RuneId);
        
        modelBuilder.Entity<RuneDirection>()
            .HasOne(e => e.Direction)
            .WithMany()
            .HasForeignKey(e => e.DirectionId);

        modelBuilder.Entity<RuneFeature>()
            .HasKey(e => new { e.RuneId, e.FeatureId });

        modelBuilder.Entity<RuneFeature>()
            .HasOne(e => e.Rune)
            .WithMany(e => e.Features)
            .HasForeignKey(e => e.RuneId);
        
        modelBuilder.Entity<RuneFeature>()
            .HasOne(e => e.Feature)
            .WithMany()
            .HasForeignKey(e => e.FeatureId);
        
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

        modelBuilder.Entity<TileLog>()
            .HasOne(e => e.Tile)
            .WithMany()
            .HasForeignKey(e => e.TileId);

        modelBuilder.Entity<TileFieldLog>()
            .HasOne(e => e.Field)
            .WithMany()
            .HasForeignKey(e => e.FieldId);

        modelBuilder.Entity<TileFieldDirectionLog>()
            .HasOne(e => e.Direction)
            .WithMany()
            .HasForeignKey(e => e.DirectionId);

        modelBuilder.Entity<TileField>()
            .HasKey(e => new { e.FieldId, e.TileId, e.PositionId });

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
        
        modelBuilder.Entity<TileField>()
            .HasOne(e => e.Direction)
            .WithMany()
            .HasForeignKey(e => e.DirectionId);

        modelBuilder.Entity<Position>()
            .HasOne(e => e.Game)
            .WithMany(e => e.Positions)
            .HasForeignKey(e => e.GameId);

        modelBuilder.Entity<UserGame>()
            .HasKey(e => new { e.UserId, e.GameId });

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

        // USER MANAGEMENT
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
        
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();
        
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.Entity<Role>()
            .HasIndex(r => r.Identifier)
            .IsUnique();
        
        modelBuilder.Entity<RoleClaim>()
            .HasKey(rc => new { rc.UserId, rc.RoleId });
        
        modelBuilder.Entity<LogEntry>()
            .Property(le => le.FieldType)
            .HasConversion<string>();
        
        modelBuilder.Entity<Role>()
            .HasData(new Role { Id = 1, Identifier = "Admin", Description = "Administrator" });
    }
}