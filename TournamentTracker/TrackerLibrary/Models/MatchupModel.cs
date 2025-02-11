using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// the teams that are entered in to this matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
        /// <summary>
        /// the team that won this matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// the round number that this matchup occurs in
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
