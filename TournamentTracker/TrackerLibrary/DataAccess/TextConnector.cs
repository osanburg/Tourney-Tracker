﻿using System;
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
        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;

            if(people.Count > 0)
            {
                currentId = people.Max(p => p.Id)+1;
            }

            model.Id = currentId;

            people.Add(model);

            people.SaveToPeopleFile();
        }

        public void CreatePrize(PrizeModel model)
        {
            // Load the text file and convert the text to List<PrizeModel>
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = 1;
            
            if (prizes.Count > 0)
            {
                currentId = prizes.Max(p => p.Id)+1;
            }
            
            model.Id = currentId;

            // Add the new record with the new ID (max+1)
            prizes.Add(model);

            
            // Convert the prizes to list<string>
            // Save the list<string> to the text file
            prizes.SaveToPrizeFile();
        }

        public void CreateTeam(TeamModel model)
        {
            // Load the text file and convert the text to List<TeamModel>
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();

            // Find the max ID
            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.Max(p => p.Id) + 1;
            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile();
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();

            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.Max(p => p.Id) + 1;
            }

            model.Id = currentId;

            model.SaveRoundsToFile();

            tournaments.Add(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }

        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

        }

        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }
    }
}
