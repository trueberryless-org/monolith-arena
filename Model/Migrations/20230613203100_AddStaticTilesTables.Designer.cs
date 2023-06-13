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
    [Migration("20230613203100_AddStaticTilesTables")]
    partial class AddStaticTilesTables
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
                        .HasColumnType("longtext")
                        .HasColumnName("USERNAME");

                    b.HasKey("Id");

                    b.HasIndex("Email")
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

            modelBuilder.Entity("Model.Entities.MonolithArena.Attack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AttackType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ATTACKS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.ChampionAttack", b =>
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

            modelBuilder.Entity("Model.Entities.MonolithArena.ChampionFeature", b =>
                {
                    b.Property<int>("ChampionId")
                        .HasColumnType("int")
                        .HasColumnName("CHAMPION_ID");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int")
                        .HasColumnName("FEATURE_ID");

                    b.HasKey("ChampionId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("CHAMPION_HAS_FEATURES_JT");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.ChampionInitiative", b =>
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

            modelBuilder.Entity("Model.Entities.MonolithArena.Direction", b =>
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

            modelBuilder.Entity("Model.Entities.MonolithArena.Faction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("FACTIONS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Feature", b =>
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

            modelBuilder.Entity("Model.Entities.MonolithArena.Initiative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("INITIATIVES");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.RuneDirection", b =>
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

            modelBuilder.Entity("Model.Entities.MonolithArena.RuneFeature", b =>
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

            modelBuilder.Entity("Model.Entities.MonolithArena.Tile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FactionId")
                        .HasColumnType("int")
                        .HasColumnName("FACTION_ID");

                    b.HasKey("Id");

                    b.HasIndex("FactionId");

                    b.ToTable("TILES_BT");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Champion", b =>
                {
                    b.HasBaseType("Model.Entities.MonolithArena.Tile");

                    b.Property<string>("ChampionType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("CHAMPIONS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Order", b =>
                {
                    b.HasBaseType("Model.Entities.MonolithArena.Tile");

                    b.ToTable("ORDERS_BT");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Rune", b =>
                {
                    b.HasBaseType("Model.Entities.MonolithArena.Tile");

                    b.Property<string>("RuneType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("RUNES");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Command", b =>
                {
                    b.HasBaseType("Model.Entities.MonolithArena.Order");

                    b.Property<string>("OrderType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("ORDER_COMMANDS");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.LogicGate", b =>
                {
                    b.HasBaseType("Model.Entities.MonolithArena.Order");

                    b.Property<int>("LogicGateType")
                        .HasColumnType("int");

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

            modelBuilder.Entity("Model.Entities.MonolithArena.ChampionAttack", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.Attack", "Attack")
                        .WithMany()
                        .HasForeignKey("AttackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.Champion", "Champion")
                        .WithMany("Attacks")
                        .HasForeignKey("ChampionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.Direction", "Direction")
                        .WithMany()
                        .HasForeignKey("DirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attack");

                    b.Navigation("Champion");

                    b.Navigation("Direction");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.ChampionFeature", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.Champion", "Champion")
                        .WithMany("Features")
                        .HasForeignKey("ChampionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Champion");

                    b.Navigation("Feature");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.ChampionInitiative", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.Champion", "Champion")
                        .WithMany("Initiatives")
                        .HasForeignKey("ChampionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.Initiative", "Initiative")
                        .WithMany()
                        .HasForeignKey("InitiativeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Champion");

                    b.Navigation("Initiative");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.RuneDirection", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.Direction", "Direction")
                        .WithMany()
                        .HasForeignKey("DirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.Rune", "Rune")
                        .WithMany("Directions")
                        .HasForeignKey("RuneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Direction");

                    b.Navigation("Rune");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.RuneFeature", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.Rune", "Rune")
                        .WithMany("Features")
                        .HasForeignKey("RuneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Rune");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Tile", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.Faction", "Faction")
                        .WithMany("Tiles")
                        .HasForeignKey("FactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faction");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Champion", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.Tile", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.Champion", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Order", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.Tile", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.Order", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Rune", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.Tile", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.Rune", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Command", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.Order", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.Command", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.LogicGate", b =>
                {
                    b.HasOne("Model.Entities.MonolithArena.Order", null)
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.LogicGate", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.Order", "OptionOneOrder")
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.LogicGate", "OptionOneOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.MonolithArena.Order", "OptionTwoOrder")
                        .WithOne()
                        .HasForeignKey("Model.Entities.MonolithArena.LogicGate", "OptionTwoOrderId")
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
                    b.Navigation("RoleClaims");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Faction", b =>
                {
                    b.Navigation("Tiles");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Champion", b =>
                {
                    b.Navigation("Attacks");

                    b.Navigation("Features");

                    b.Navigation("Initiatives");
                });

            modelBuilder.Entity("Model.Entities.MonolithArena.Rune", b =>
                {
                    b.Navigation("Directions");

                    b.Navigation("Features");
                });
#pragma warning restore 612, 618
        }
    }
}