using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace bowlingApp.Data
{
    public partial class BowlingLeagueContext : DbContext
    {

        //connect to the DB :) 
        public BowlingLeagueContext(DbContextOptions<BowlingLeagueContext> options)
            : base(options)
        {
        }

        //get bowlers and teams
        public DbSet<Bowler> Bowlers { get; set; }

        public DbSet<Team> Teams { get; set; }

    }
}
