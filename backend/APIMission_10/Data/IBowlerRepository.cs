﻿namespace bowlingApp.Data
{
    public interface IBowlerRepository
    {
        //pull in info stuff
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
    }
}
