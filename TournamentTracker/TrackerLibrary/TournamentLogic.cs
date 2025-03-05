using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // order list of teams randomly
        // check if list is big enough(2^n teams), if not add in byes (14 teams: add in 2 byes)
        // create first round of matchups
        // create every round after that (16 teams: 8 matchups - 4 matchups - 2 matchups - 1 matchup)

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = FindNumberOfByes(rounds, randomizedTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));

            CreateOtherRounds(model, rounds);
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds)
            {
                // each loop from list of matchups from the previous round: add a matchup entry from previous round to a matchup of the current round,
                // then if the are two matchup entries in the matchup: add the matchup to the current round and create a new matchup
                foreach (MatchupModel match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

                    if(currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }

                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<MatchupModel>();
                round++;
            }
        }

        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            // each loop from list of teams in the tourney: add a team to the matchup,
            // then if there is bye or two teams in the matchup: add the matchup to the output then create a new matchup
            foreach(TeamModel team in teams)
            {
                currMatchup.Entries.Add(new MatchupEntryModel {TeamCompeting = team});

                if (byes > 0 || currMatchup.Entries.Count > 1)
                {
                    currMatchup.MatchupRound = 1;
                    output.Add(currMatchup);
                    currMatchup = new MatchupModel();

                    if(byes > 0)
                    {
                        byes--;
                    }
                }
            }

            return output;
        }

        private static int FindNumberOfByes(int rounds, int numberOfTeams)
        {
            int totalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            return totalTeams - numberOfTeams;
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {
                output++;
                val *= 2;
            }

            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            Random rng = new Random();
            
            return teams.OrderBy(x => rng.Next()).ToList();
        }


    }
}
