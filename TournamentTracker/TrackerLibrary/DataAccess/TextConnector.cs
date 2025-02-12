using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFiles = "PrizeModels.csv";

        // TODO - make the CreatePrize method actually save to a text file
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file and convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFiles.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = 1;
            
            if (prizes.Count > 0)
            {
                currentId = prizes.Max(p => p.Id);
            }
            
            model.Id = currentId;

            // Add the new record with the new ID (max+1)
            prizes.Add(model);

            
            // Convert the prizes to list<string>
            // Save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFiles);

            return model;
        }
    }
}
