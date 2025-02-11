using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// the name of this tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// the entry fee of this tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// the teams that have entered this tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// the prizes offered in this tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// the rounds of this tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
