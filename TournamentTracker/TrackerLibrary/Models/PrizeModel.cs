using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// the unique Id number of the prize
        /// </summary>
        public int Id { get; set; }
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
        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
