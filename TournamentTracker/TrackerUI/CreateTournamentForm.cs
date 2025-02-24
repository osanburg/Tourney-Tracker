using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        /// <summary>
        /// Enables the list boxes in the form to display data
        /// </summary>
        private void WireUpLists()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            TournamentTeamsListBox.DataSource = null;
            TournamentTeamsListBox.DataSource = selectedTeams;
            TournamentTeamsListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;

            if(t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
            
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            // Call CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

            // Get back PrizeModel from the form
            // Take the prize model and put it in list of selected prizes
        }

        public void PrizeComplete(PrizeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
