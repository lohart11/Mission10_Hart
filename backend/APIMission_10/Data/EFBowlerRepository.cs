using Microsoft.EntityFrameworkCore;

namespace bowlingApp.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _Context;
        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            _Context = temp;
        }
        public IEnumerable<Bowler> Bowlers => _Context.Bowlers
            .Include(b => b.Team)
            .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
            .ToList();

        public IEnumerable<Team> Teams => _Context.Teams;
    }
}
