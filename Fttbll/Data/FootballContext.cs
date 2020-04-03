using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fttbll.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Fttbll.Data;

namespace Fttbll.Data
{
    public class FootballContext : DbContext
    {
        public FootballContext(DbContextOptions<FootballContext> options) : base(options)
        {
        }

        public DbSet<Championship> Championships { get; set; }
        public DbSet<ChampionshipCommand> ChampionshipCommands { get; set; }
        public DbSet<Command> Commands { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Championship>().ToTable("Championship");
            modelBuilder.Entity<ChampionshipCommand>().ToTable("ChampionshipCommand");
            modelBuilder.Entity<Command>().ToTable("Command");
            modelBuilder.Entity<Player>().ToTable("Player");
            modelBuilder.Entity<Match>().ToTable("Match");
        }
    }
}
