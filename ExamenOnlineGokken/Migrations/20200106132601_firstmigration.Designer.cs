﻿// <auto-generated />
using System;
using ExamenOnlineGokken.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamenOnlineGokken.Migrations
{
    [DbContext(typeof(GambleDbContext))]
    [Migration("20200106132601_firstmigration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamenOnlineGokken.Entities.Bet", b =>
                {
                    b.Property<long>("GameId");

                    b.Property<long>("UserId");

                    b.Property<decimal>("BetAmount")
                        .HasColumnType("Decimal");

                    b.Property<string>("Outcome");

                    b.HasKey("GameId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Bets");

                    b.HasData(
                        new
                        {
                            GameId = 1L,
                            UserId = 1L,
                            BetAmount = 0m
                        },
                        new
                        {
                            GameId = 6L,
                            UserId = 1L,
                            BetAmount = 0m
                        },
                        new
                        {
                            GameId = 10L,
                            UserId = 1L,
                            BetAmount = 0m
                        },
                        new
                        {
                            GameId = 9L,
                            UserId = 2L,
                            BetAmount = 0m
                        },
                        new
                        {
                            GameId = 11L,
                            UserId = 2L,
                            BetAmount = 0m
                        },
                        new
                        {
                            GameId = 12L,
                            UserId = 2L,
                            BetAmount = 0m
                        },
                        new
                        {
                            GameId = 16L,
                            UserId = 3L,
                            BetAmount = 0m
                        },
                        new
                        {
                            GameId = 8L,
                            UserId = 3L,
                            BetAmount = 0m
                        },
                        new
                        {
                            GameId = 13L,
                            UserId = 3L,
                            BetAmount = 0m
                        },
                        new
                        {
                            GameId = 14L,
                            UserId = 3L,
                            BetAmount = 0m
                        },
                        new
                        {
                            GameId = 3L,
                            UserId = 4L,
                            BetAmount = 0m
                        });
                });

            modelBuilder.Entity("ExamenOnlineGokken.Entities.Game", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AwayTeam");

                    b.Property<DateTime>("DateOfGame");

                    b.Property<string>("Hometeam");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AwayTeam = "Cagliari",
                            DateOfGame = new DateTime(2020, 1, 20, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Juventus"
                        },
                        new
                        {
                            Id = 2L,
                            AwayTeam = "Pescara",
                            DateOfGame = new DateTime(2020, 1, 21, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Inter"
                        },
                        new
                        {
                            Id = 3L,
                            AwayTeam = "Cagliari",
                            DateOfGame = new DateTime(2020, 1, 20, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Napoli"
                        },
                        new
                        {
                            Id = 4L,
                            AwayTeam = "Bologna",
                            DateOfGame = new DateTime(2020, 1, 20, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Milan"
                        },
                        new
                        {
                            Id = 5L,
                            AwayTeam = "Cercle Brugge",
                            DateOfGame = new DateTime(2020, 1, 23, 13, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Club Brugge"
                        },
                        new
                        {
                            Id = 6L,
                            AwayTeam = "AA Gent",
                            DateOfGame = new DateTime(2020, 1, 23, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "KRC Genk"
                        },
                        new
                        {
                            Id = 7L,
                            AwayTeam = "FC Antwerp",
                            DateOfGame = new DateTime(2020, 1, 23, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Standard"
                        },
                        new
                        {
                            Id = 8L,
                            AwayTeam = "Cercle Brugge",
                            DateOfGame = new DateTime(2020, 1, 23, 13, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Club Brugge"
                        },
                        new
                        {
                            Id = 9L,
                            AwayTeam = "Liverpool",
                            DateOfGame = new DateTime(2020, 2, 18, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Atletico Madrid"
                        },
                        new
                        {
                            Id = 10L,
                            AwayTeam = "Valencia",
                            DateOfGame = new DateTime(2020, 2, 19, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Atalanta"
                        },
                        new
                        {
                            Id = 11L,
                            AwayTeam = "Bayern",
                            DateOfGame = new DateTime(2020, 2, 19, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Chelsea"
                        },
                        new
                        {
                            Id = 12L,
                            AwayTeam = "Barcelona",
                            DateOfGame = new DateTime(2020, 2, 25, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Napoli"
                        },
                        new
                        {
                            Id = 13L,
                            AwayTeam = "Inter Milan",
                            DateOfGame = new DateTime(2020, 2, 20, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Ludogorets"
                        },
                        new
                        {
                            Id = 14L,
                            AwayTeam = "Man United",
                            DateOfGame = new DateTime(2020, 2, 20, 21, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Club Brugge"
                        },
                        new
                        {
                            Id = 15L,
                            AwayTeam = "AS Roma",
                            DateOfGame = new DateTime(2020, 2, 27, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "AA Gent"
                        },
                        new
                        {
                            Id = 16L,
                            AwayTeam = "Arsenal",
                            DateOfGame = new DateTime(2020, 2, 21, 20, 30, 0, 0, DateTimeKind.Unspecified),
                            Hometeam = "Olympiacos"
                        });
                });

            modelBuilder.Entity("ExamenOnlineGokken.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Password = "qsdflkjqmlj43ézearf",
                            UserName = "Mileto"
                        },
                        new
                        {
                            Id = 2L,
                            Password = "qsdflkjqmlj43ézearf",
                            UserName = "Bart"
                        },
                        new
                        {
                            Id = 3L,
                            Password = "qsdflkjqmlj43ézearf",
                            UserName = "William"
                        },
                        new
                        {
                            Id = 4L,
                            Password = "qsdflkjqmlj43ézearf",
                            UserName = "Siegfried"
                        },
                        new
                        {
                            Id = 5L,
                            Password = "qsdflkjqmlj43ézearf",
                            UserName = "Joachim"
                        });
                });

            modelBuilder.Entity("ExamenOnlineGokken.Entities.Bet", b =>
                {
                    b.HasOne("ExamenOnlineGokken.Entities.Game", "Game")
                        .WithMany("Bets")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExamenOnlineGokken.Entities.User", "User")
                        .WithMany("Bets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
