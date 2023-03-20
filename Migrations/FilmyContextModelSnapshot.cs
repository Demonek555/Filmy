﻿// <auto-generated />
using System;
using Filmy.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Filmy.Migrations
{
    [DbContext(typeof(FilmyContext))]
    partial class FilmyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Filmy.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DataDodania")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Rezyser")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("czasTrwania")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriaID");

                    b.ToTable("Filmy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cena = 10m,
                            DataDodania = new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaID = 1,
                            Opis = "Strudzony życiem komik popada w obłęd i staje się psychopatycznym mordercą.",
                            Rezyser = "Todd Phillips",
                            Tytul = "Joker",
                            czasTrwania = 0
                        },
                        new
                        {
                            Id = 2,
                            Cena = 15m,
                            DataDodania = new DateTime(1995, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaID = 1,
                            Opis = "Dwóch policjantów stara się złapać seryjnego mordercę wybierającego swoje ofiary według specjalnego klucza - siedmiu grzechów głównych.",
                            Rezyser = "David Fincher",
                            Tytul = "Siedem",
                            czasTrwania = 0
                        },
                        new
                        {
                            Id = 3,
                            Cena = 20m,
                            DataDodania = new DateTime(2011, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaID = 2,
                            Opis = "Sparaliżowany milioner zatrudnia do opieki młodego chłopaka z przedmieścia, który właśnie wyszedł z więzienia.",
                            Rezyser = "Olivier Nakache, Éric Toledano",
                            Tytul = "Nietykalni",
                            czasTrwania = 0
                        },
                        new
                        {
                            Id = 4,
                            Cena = 25m,
                            DataDodania = new DateTime(1997, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaID = 2,
                            Opis = "Zamknięty w obozie koncentracyjnym wraz z synem Guido próbuje przekonać chłopca, że okrutna rzeczywistość jest jedynie formą zabawy dla dorosłych.",
                            Rezyser = "Roberto Benigni, Vincenzo Cerami",
                            Tytul = "Życie jest piękne",
                            czasTrwania = 0
                        },
                        new
                        {
                            Id = 5,
                            Cena = 30m,
                            DataDodania = new DateTime(1979, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaID = 3,
                            Opis = "Zamknięty w obozie koncentracyjnym wraz z synem Guido próbuje przekonać chłopca, że okrutna rzeczywistość jest jedynie formą zabawy dla dorosłych.",
                            Rezyser = "Ridley Scott",
                            Tytul = "Obcy - 8. pasażer Nostromo",
                            czasTrwania = 0
                        },
                        new
                        {
                            Id = 6,
                            Cena = 5m,
                            DataDodania = new DateTime(1980, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaID = 3,
                            Opis = "Jack podejmuje pracę stróża odciętego od świata hotelu Overlook. Wkrótce idylla zamienia się w koszmar.",
                            Rezyser = "Stanley Kubrick",
                            Tytul = "Lśnienie",
                            czasTrwania = 0
                        },
                        new
                        {
                            Id = 7,
                            Cena = 15m,
                            DataDodania = new DateTime(1999, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaID = 4,
                            Opis = "Cierpiący na bezsenność mężczyzna poznaje gardzącego konsumpcyjnym stylem życia Tylera Durdena, który jest jego zupełnym przeciwieństwem.",
                            Rezyser = "David Fincher",
                            Tytul = "Podziemny krąg",
                            czasTrwania = 0
                        },
                        new
                        {
                            Id = 8,
                            Cena = 12m,
                            DataDodania = new DateTime(2010, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaID = 4,
                            Opis = "Czasy, gdy technologia pozwala na wchodzenie w świat snów. Złodziej Cobb ma za zadanie wszczepić myśl do śpiącego umysłu.",
                            Rezyser = "Christopher Nolan",
                            Tytul = "Incepcja",
                            czasTrwania = 0
                        },
                        new
                        {
                            Id = 9,
                            Cena = 14m,
                            DataDodania = new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaID = 5,
                            Opis = "Po ponad 20 latach służby w lotnictwie marynarki wojennej, Pete Maverick Mitchell zostaje wezwany do legendarnej szkoły Top Gun. Ma wyszkolić nowe pokolenie pilotów do niezwykle trudnej misji.",
                            Rezyser = "Joseph Kosinski",
                            Tytul = "Top Gun: Maverick",
                            czasTrwania = 0
                        },
                        new
                        {
                            Id = 10,
                            Cena = 21m,
                            DataDodania = new DateTime(2018, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaID = 5,
                            Opis = "Potężny Thanos zbiera Kamienie Nieskończoności w celu narzucenia swojej woli wszystkim istnieniom we wszechświecie. Tylko drużyna superbohaterów znanych jako Avengers może go powstrzymać.",
                            Rezyser = "Anthony Russo, Joe Russo",
                            Tytul = "Avengers: Wojna bez granic",
                            czasTrwania = 0
                        });
                });

            modelBuilder.Entity("Filmy.Models.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nazwa = "Kryminal",
                            Opis = "Film o tematyce kryminalnej"
                        },
                        new
                        {
                            Id = 2,
                            Nazwa = "Komedia",
                            Opis = "Film o tematyce komediowej"
                        },
                        new
                        {
                            Id = 3,
                            Nazwa = "Horror",
                            Opis = "Film grozy"
                        },
                        new
                        {
                            Id = 4,
                            Nazwa = "Thriller",
                            Opis = "Dreszczowiec"
                        },
                        new
                        {
                            Id = 5,
                            Nazwa = "Akcja",
                            Opis = "Film Akcji"
                        });
                });

            modelBuilder.Entity("Filmy.Models.Film", b =>
                {
                    b.HasOne("Filmy.Models.Kategoria", "Kategoria")
                        .WithMany("Filmy")
                        .HasForeignKey("KategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoria");
                });

            modelBuilder.Entity("Filmy.Models.Kategoria", b =>
                {
                    b.Navigation("Filmy");
                });
#pragma warning restore 612, 618
        }
    }
}
