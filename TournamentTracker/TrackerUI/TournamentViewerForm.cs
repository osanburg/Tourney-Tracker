using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            TounamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            RoundDropDown.DataSource = rounds;
            MatchupListBox.DataSource = selectedMatchups;
            MatchupListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach(List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);                  
                }
            }

            LoadMatchups(1);
        }

        private void RoundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropDown.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner ==  null || !UnplayedOnlyCheckbox.Checked)
                        {
                            selectedMatchups.Add(m); 
                        }
                    }
                }
            }

            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First()); 
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);
            
            TeamOneName.Visible = isVisible;
            TeamOneScoreLabel.Visible = isVisible;
            TeamOneScoreValue.Visible = isVisible;
            TeamTwoName.Visible = isVisible;
            TeamTwoScoreLabel.Visible = isVisible;
            TeamTwoScoreValue.Visible = isVisible;
            VSLabel.Visible = isVisible;
            ScoreButton.Visible = isVisible;
        }

        private void LoadMatchup(MatchupModel m)
        {
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        TeamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        TeamOneScoreValue.Text = m.Entries[0].Score.ToString();

                        TeamTwoName.Text = "*bye*";
                        TeamTwoScoreValue.Text = "0";
                    }
                    else
                    {
                        TeamOneName.Text = "Not Yet Set";
                        TeamOneScoreValue.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        TeamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        TeamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        TeamTwoName.Text = "Not Yet Set";
                        TeamTwoScoreValue.Text = "";
                    }
                }
            }
        }

        private void MatchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectedMatchups.Count > 0)
            {
                LoadMatchup((MatchupModel)MatchupListBox.SelectedItem);
            }
            
        }

        private void UnplayedOnlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropDown.SelectedItem);
        }

        private string ValidateData()
        {
            string output = "";

            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(TeamOneScoreValue.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(TeamTwoScoreValue.Text, out teamTwoScore);

            if (!scoreOneValid)
            {
                output += "Team One score is not a valid number\n";
            }
            
            if (!scoreTwoValid)
            {
                output += "Team Two score is not a valid number\n";
            }

            else if (teamOneScore == 0 && teamTwoScore == 0)
            {
                output += "Neither teams have a score\n";
            }

            else if(teamOneScore == teamTwoScore)
            {
                output += "Tie games are not allowed\n";
            }

            return output;
        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();
            if (errorMessage.Length > 0)
            {
                MessageBox.Show($"Input Error:\n{errorMessage}");
                return;
            }

            MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(TeamOneScoreValue.Text, out teamOneScore);
                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("The score for Team 1 is invalid!");
                            return;
                        }
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(TeamTwoScoreValue.Text, out teamTwoScore);
                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("The score for Team 2 is invalid!");
                            return;
                        }
                    }
                }
            }

             try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"The application had the following error: {ex.Message}");
                return;
            }

            LoadMatchups((int)RoundDropDown.SelectedItem);
        }
    }
}
