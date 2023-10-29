using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class StatContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<TeamPlayer> TeamPlayers { get; set; }
        public DbSet<Auth> LogDatas { get; set; }
    }
}