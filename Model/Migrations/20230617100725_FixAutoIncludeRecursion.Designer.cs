﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Configuration;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(ModelDbContext))]
    [Migration("20230617100725_FixAutoIncludeRecursion")]
    partial class FixAutoIncludeRecursion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Model.Entities.Authentication.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ROLE_ID");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("IDENTIFIER");

                    b.HasKey("Id");

                    b.HasIndex("Identifier")
                        .IsUnique();

                    b.ToTable("ROLES");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Administrator",
                            Identifier = "Admin"
                        });
                });

            modelBuilder.Entity("Model.Entities.Authentication.RoleClaim", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("ROLE_ID");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("USER_HAS_ROLES_JT");
                });

            modelBuilder.Entity("Model.Entities.Authentication.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("PASSWORD_HASH");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("USERNAME");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("USERS");
                });

            modelBuilder.Entity("Model.Entities.Log.LogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LOG_ID");

                    b.Property<DateOnly>("DateValue")
                        .HasColumnType("date")
                        .HasColumnName("CHANGE_DATE");

                    b.Property<string>("FieldType")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("FIELD_TYPE");

                    b.Property<string>("NewValue")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NEW_VALUE");

                    b.Property<string>("OldValue")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("OLD_VALUE");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("LOG_ENTRIES");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Attack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AttackType")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ATTACK_TYPE");

                    b.HasKey("Id");

                    b.ToTable("ATTACKS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.ChampionAttack", b =>
                {
                    b.Property<int>("ChampionId")
                        .HasColumnType("int")
                        .HasColumnName("CHAMPION_ID");

                    b.Property<int>("AttackId")
                        .HasColumnType("int")
                        .HasColumnName("ATTACK_ID");

                    b.Property<int>("DirectionId")
                        .HasColumnType("int")
                        .HasColumnName("DIRECTION_ID");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.HasKey("ChampionId", "AttackId", "DirectionId");

                    b.HasIndex("AttackId");

                    b.HasIndex("DirectionId");

                    b.ToTable("CHAMPION_HAS_ATTACKS_JT");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.ChampionFeature", b =>
                {
                    b.Property<int>("ChampionId")
                        .HasColumnType("int")
                        .HasColumnName("CHAMPION_ID");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int")
                        .HasColumnName("FEATURE_ID");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("QUANTITY");

                    b.HasKey("ChampionId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("CHAMPION_HAS_FEATURES_JT");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.ChampionInitiative", b =>
                {
                    b.Property<int>("ChampionId")
                        .HasColumnType("int")
                        .HasColumnName("CHAMPION_ID");

                    b.Property<int>("InitiativeId")
                        .HasColumnType("int")
                        .HasColumnName("INITIATIVE_ID");

                    b.HasKey("ChampionId", "InitiativeId");

                    b.HasIndex("InitiativeId");

                    b.ToTable("CHAMPION_HAS_INITIATIVES_JT");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Direction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DirectionType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DIRECTIONS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Faction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("FACTIONS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FeatureType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("FEATURES");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.Property<int>("Z")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FIELDS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Initiative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("INITIATIVES");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.RuneDirection", b =>
                {
                    b.Property<int>("RuneId")
                        .HasColumnType("int")
                        .HasColumnName("RUNE_ID");

                    b.Property<int>("DirectionId")
                        .HasColumnType("int")
                        .HasColumnName("DIRECTION_ID");

                    b.HasKey("RuneId", "DirectionId");

                    b.HasIndex("DirectionId");

                    b.ToTable("RUNE_HAS_DIRECTIONS_JT");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.RuneFeature", b =>
                {
                    b.Property<int>("RuneId")
                        .HasColumnType("int")
                        .HasColumnName("RUNE_ID");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int")
                        .HasColumnName("FEATURE_ID");

                    b.HasKey("RuneId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("RUNE_HAS_FEATURES_JT");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Tile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FactionId")
                        .HasColumnType("int")
                        .HasColumnName("FACTION_ID");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("QUANTITY");

                    b.HasKey("Id");

                    b.HasIndex("FactionId");

                    b.ToTable("TILES_BT");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.InGame.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GAMES");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.InGame.GameLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DirectionId")
                        .HasColumnType("int")
                        .HasColumnName("FACING");

                    b.Property<int?>("FieldId")
                        .HasColumnType("int")
                        .HasColumnName("FIELD_ID");

                    b.Property<int>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("GAME_ID");

                    b.Property<string>("LogType")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("LOG_TYPE");

                    b.Property<int>("PositionId")
                        .HasColumnType("int")
                        .HasColumnName("POSITION_ID");

                    b.Property<int?>("TileId")
                        .HasColumnType("int")
                        .HasColumnName("TILE_ID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("DirectionId");

                    b.HasIndex("FieldId");

                    b.HasIndex("GameId");

                    b.HasIndex("PositionId");

                    b.HasIndex("TileId");

                    b.HasIndex("UserId");

                    b.ToTable("GAME_LOGS_BT");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.InGame.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("GAME_ID");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("POSITIONS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.InGame.TileField", b =>
                {
                    b.Property<int>("FieldId")
                        .HasColumnType("int")
                        .HasColumnName("FIELD_ID");

                    b.Property<int>("TileId")
                        .HasColumnType("int")
                        .HasColumnName("TILE_ID");

                    b.Property<int>("PositionId")
                        .HasColumnType("int")
                        .HasColumnName("POSITION_ID");

                    b.Property<int>("DirectionId")
                        .HasColumnType("int")
                        .HasColumnName("FACING");

                    b.HasKey("FieldId", "TileId", "PositionId");

                    b.HasIndex("DirectionId");

                    b.HasIndex("PositionId");

                    b.HasIndex("TileId");

                    b.ToTable("TILE_OCCUPIES_FIELD_JT");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.InGame.UserGame", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.Property<int>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("GAME_ID");

                    b.Property<int>("FactionId")
                        .HasColumnType("int")
                        .HasColumnName("FACTION_ID");

                    b.HasKey("UserId", "GameId");

                    b.HasIndex("FactionId");

                    b.HasIndex("GameId");

                    b.ToTable("USER_PLAYS_GAMES_JT");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Champion", b =>
                {
                    b.HasBaseType("Model.Entities.MonolithArena.GameContent.Tile");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.ToTable("CHAMPIONS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Order", b =>
                {
                    b.HasBaseType("Model.Entities.MonolithArena.GameContent.Tile");

                    b.ToTable("ORDERS_BT");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Rune", b =>
                {
                    b.HasBaseType("Model.Entities.MonolithArena.GameContent.Tile");

                    b.Property<string>("RuneType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SpecialFeatureId")
                        .HasColumnType("int")
                        .HasColumnName("SPECIAL_FEATURE_ID");

                    b.HasIndex("SpecialFeatureId");

                    b.ToTable("RUNES");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Banner", b =>
                {
                    b.HasBaseType("Model.Entities.MonolithArena.GameContent.Champion");

                    b.Property<int>("SpecialFeatureId")
                        .HasColumnType("int")
                        .HasColumnName("SPECIAL_FEATURE_ID");

                    b.HasIndex("SpecialFeatureId");

                    b.ToTable("BANNERS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Command", b =>
                {
                    b.HasBaseType("Model.Entities.MonolithArena.GameContent.Order");

                    b.Property<string>("OrderType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("ORDER_COMMANDS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.LogicGate", b =>
                {
                    b.HasBaseType("Model.Entities.MonolithArena.GameContent.Order");

                    b.Property<string>("LogicGateType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OptionOneOrderId")
                        .HasColumnType("int")
                        .HasColumnName("OPTION_ONE_ORDER_ID");

                    b.Property<int>("OptionTwoOrderId")
                        .HasColumnType("int")
                        .HasColumnName("OPTION_TWO_ORDER_ID");

                    b.HasIndex("OptionOneOrderId")
                        .IsUnique();

                    b.HasIndex("OptionTwoOrderId")
                        .IsUnique();

                    b.ToTable("ORDER_LOGIC_GATES");
                });

            modelBuilder.Entity("Model.Entities.Authentication.RoleClaim", b =>
                {
                    b.HasOne("Model.Entities.Authentication.Role", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Authentication.User", "User")
                        .WithMany("RoleClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Model.Entities.Log.LogEntry", b =>
                {
                    b.HasOne("Model.Entities.Authentication.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.ChampionAttack", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Attack", "Attack")
                        .WithMany()
                        .HasForeignKey("AttackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Champion", "Champion")
                        .WithMany("Attacks")
                        .HasForeignKey("ChampionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Direction", "Direction")
                        .WithMany()
                        .HasForeignKey("DirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attack");

                    b.Navigation("Champion");

                    b.Navigation("Direction");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.ChampionFeature", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Champion", "Champion")
                        .WithMany("Features")
                        .HasForeignKey("ChampionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Champion");

                    b.Navigation("Feature");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.ChampionInitiative", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Champion", "Champion")
                        .WithMany("Initiatives")
                        .HasForeignKey("ChampionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Initiative", "Initiative")
                        .WithMany()
                        .HasForeignKey("InitiativeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Champion");

                    b.Navigation("Initiative");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.RuneDirection", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Direction", "Direction")
                        .WithMany()
                        .HasForeignKey("DirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Rune", "Rune")
                        .WithMany("Directions")
                        .HasForeignKey("RuneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direction");

                    b.Navigation("Rune");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.RuneFeature", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Rune", "Rune")
                        .WithMany("Features")
                        .HasForeignKey("RuneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Rune");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Tile", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Faction", "Faction")
                        .WithMany("Tiles")
                        .HasForeignKey("FactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faction");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.InGame.GameLog", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Direction", "Direction")
                        .WithMany()
                        .HasForeignKey("DirectionId");

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId");

                    b.HasOne("Model.Entities.MonolithArena.InGame.Game", "Game")
                        .WithMany("Logs")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.InGame.Position", "Position")
                        .WithMany("Logs")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Tile", "Tile")
                        .WithMany()
                        .HasForeignKey("TileId");

                    b.HasOne("Model.Entities.Authentication.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direction");

                    b.Navigation("Field");

                    b.Navigation("Game");

                    b.Navigation("Position");

                    b.Navigation("Tile");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.InGame.Position", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.InGame.Game", "Game")
                        .WithMany("Positions")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.InGame.TileField", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Direction", "Direction")
                        .WithMany()
                        .HasForeignKey("DirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.InGame.Position", "Position")
                        .WithMany("Fields")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Tile", "Tile")
                        .WithMany()
                        .HasForeignKey("TileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direction");

                    b.Navigation("Field");

                    b.Navigation("Position");

                    b.Navigation("Tile");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.InGame.UserGame", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Faction", "Faction")
                        .WithMany()
                        .HasForeignKey("FactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.InGame.Game", "Game")
                        .WithMany("Users")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Authentication.User", "User")
                        .WithMany("Games")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faction");

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Champion", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Tile", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.GameContent.Champion", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Order", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Tile", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.GameContent.Order", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Rune", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Tile", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.GameContent.Rune", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Feature", "SpecialFeature")
                        .WithMany()
                        .HasForeignKey("SpecialFeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SpecialFeature");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Banner", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Champion", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.GameContent.Banner", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Feature", "SpecialFeature")
                        .WithMany()
                        .HasForeignKey("SpecialFeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SpecialFeature");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Command", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Order", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.GameContent.Command", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.LogicGate", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.GameContent.Order", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.GameContent.LogicGate", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Order", "OptionOneOrder")
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.GameContent.LogicGate", "OptionOneOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.GameContent.Order", "OptionTwoOrder")
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.GameContent.LogicGate", "OptionTwoOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OptionOneOrder");

                    b.Navigation("OptionTwoOrder");
                });

            modelBuilder.Entity("Model.Entities.Authentication.Role", b =>
                {
                    b.Navigation("RoleClaims");
                });

            modelBuilder.Entity("Model.Entities.Authentication.User", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("RoleClaims");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Faction", b =>
                {
                    b.Navigation("Tiles");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.InGame.Game", b =>
                {
                    b.Navigation("Logs");

                    b.Navigation("Positions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.InGame.Position", b =>
                {
                    b.Navigation("Fields");

                    b.Navigation("Logs");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Champion", b =>
                {
                    b.Navigation("Attacks");

                    b.Navigation("Features");

                    b.Navigation("Initiatives");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.GameContent.Rune", b =>
                {
                    b.Navigation("Directions");

                    b.Navigation("Features");
                });
#pragma warning restore 612, 618
        }
    }
}
