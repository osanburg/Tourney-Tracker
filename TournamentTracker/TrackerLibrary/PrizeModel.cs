using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// the placement in the tournament that receives this prize
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// the name of the placement that receives this prize
        /// </summary>
        public String PlaceName { get; set; }
        /// <summary>
        /// the amount of this prize (if applicable)
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// the percentage that this prize takes from the tournament's pot (if applicable)
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
