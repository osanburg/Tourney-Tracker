using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// the Id of this team
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// the name of this team
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// the people that are in this team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        

    }
}
