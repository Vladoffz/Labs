﻿// <auto-generated />
using System;
using Fttbll.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fttbll.Migrations
{
    [DbContext(typeof(FootballContext))]
    [Migration("20200327150526_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fttbll.Models.Championship", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Championship");
                });

            modelBuilder.Entity("Fttbll.Models.ChampionshipCommand", b =>
                {
                    b.Property<int>("ChampionshipCommandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChampionshipID")
                        .HasColumnType("int");

                    b.Property<int>("CommandID")
                        .HasColumnType("int");

                    b.HasKey("ChampionshipCommandID");

                    b.HasIndex("ChampionshipID");

                    b.HasIndex("CommandID");

                    b.ToTable("ChampionshipCommand");
                });

            modelBuilder.Entity("Fttbll.Models.Command", b =>
                {
                    b.Property<int>("CommandID")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MatchID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.HasKey("CommandID");

                    b.HasIndex("MatchID");

                    b.ToTable("Command");
                });

            modelBuilder.Entity("Fttbll.Models.Match", b =>
                {
                    b.Property<int>("MatchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommandID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataProvedeniya")
                        .HasColumnType("datetime2");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.HasKey("MatchID");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("Fttbll.Models.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Command")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CommandID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CommandID");

                    b.HasIndex("PlayerID");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Fttbll.Models.ChampionshipCommand", b =>
                {
                    b.HasOne("Fttbll.Models.Championship", "Championship")
                        .WithMany()
                        .HasForeignKey("ChampionshipID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fttbll.Models.Command", "Command")
                        .WithMany()
                        .HasForeignKey("CommandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fttbll.Models.Command", b =>
                {
                    b.HasOne("Fttbll.Models.Match", null)
                        .WithMany("Commands")
                        .HasForeignKey("MatchID");
                });

            modelBuilder.Entity("Fttbll.Models.Player", b =>
                {
                    b.HasOne("Fttbll.Models.Command", null)
                        .WithMany("Players")
                        .HasForeignKey("CommandID");

                    b.HasOne("Fttbll.Models.Player", null)
                        .WithMany("Players")
                        .HasForeignKey("PlayerID");
                });
#pragma warning restore 612, 618
        }
    }
}