using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// the unique Id number of the matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the teams that are entered in to this matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// the ID from the database that is used to identify the winner
        /// </summary>
        public int WinnerID { get; set; }
        /// <summary>
        /// the team that won this matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// the round number that this matchup occurs in
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";

                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        } 
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
