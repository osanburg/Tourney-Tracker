using System.Drawing;
using System.Windows.Forms;

namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            HeaderLabel = new Label();
            TounamentName = new Label();
            Round = new Label();
            RoundDropdown = new ComboBox();
            UnplayedOnlyCheckbox = new CheckBox();
            MatchupListBox = new ListBox();
            TeamOneName = new Label();
            TeamOneScoreLabel = new Label();
            TeamOneScoreValue = new TextBox();
            TeamTwoScoreValue = new TextBox();
            TeamTwoScoreLabel = new Label();
            TeamTwoName = new Label();
            VSLabel = new Label();
            ScoreButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = Color.FromArgb(51, 155, 255);
            HeaderLabel.Location = new Point(32, 35);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(214, 50);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Tournament:";
            // 
            // TounamentName
            // 
            TounamentName.AutoSize = true;
            TounamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TounamentName.ForeColor = Color.FromArgb(51, 155, 255);
            TounamentName.Location = new Point(252, 35);
            TounamentName.Name = "TounamentName";
            TounamentName.Size = new Size(150, 50);
            TounamentName.TabIndex = 1;
            TounamentName.Text = "<none>";
            // 
            // Round
            // 
            Round.AutoSize = true;
            Round.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Round.ForeColor = Color.FromArgb(52, 153, 255);
            Round.Location = new Point(32, 113);
            Round.Name = "Round";
            Round.Size = new Size(94, 37);
            Round.TabIndex = 2;
            Round.Text = "Round";
            // 
            // RoundDropdown
            // 
            RoundDropdown.FormattingEnabled = true;
            RoundDropdown.Location = new Point(125, 112);
            RoundDropdown.Name = "RoundDropdown";
            RoundDropdown.Size = new Size(209, 38);
            RoundDropdown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckbox
            // 
            UnplayedOnlyCheckbox.AutoSize = true;
            UnplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            UnplayedOnlyCheckbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnplayedOnlyCheckbox.ForeColor = SystemColors.MenuHighlight;
            UnplayedOnlyCheckbox.Location = new Point(125, 165);
            UnplayedOnlyCheckbox.Name = "UnplayedOnlyCheckbox";
            UnplayedOnlyCheckbox.Size = new Size(209, 41);
            UnplayedOnlyCheckbox.TabIndex = 4;
            UnplayedOnlyCheckbox.Text = "Unplayed Only";
            UnplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // MatchupListBox
            // 
            MatchupListBox.BorderStyle = BorderStyle.FixedSingle;
            MatchupListBox.FormattingEnabled = true;
            MatchupListBox.ItemHeight = 30;
            MatchupListBox.Location = new Point(32, 238);
            MatchupListBox.Name = "MatchupListBox";
            MatchupListBox.Size = new Size(302, 302);
            MatchupListBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            TeamOneName.AutoSize = true;
            TeamOneName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneName.ForeColor = Color.FromArgb(52, 153, 255);
            TeamOneName.Location = new Point(531, 238);
            TeamOneName.Name = "TeamOneName";
            TeamOneName.Size = new Size(165, 37);
            TeamOneName.TabIndex = 6;
            TeamOneName.Text = "<team one>";
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneScoreLabel.ForeColor = Color.FromArgb(52, 153, 255);
            TeamOneScoreLabel.Location = new Point(531, 303);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(82, 37);
            TeamOneScoreLabel.TabIndex = 7;
            TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            TeamOneScoreValue.Location = new Point(619, 303);
            TeamOneScoreValue.Name = "TeamOneScoreValue";
            TeamOneScoreValue.Size = new Size(100, 35);
            TeamOneScoreValue.TabIndex = 8;
            // 
            // TeamTwoScoreValue
            // 
            TeamTwoScoreValue.Location = new Point(619, 497);
            TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            TeamTwoScoreValue.Size = new Size(100, 35);
            TeamTwoScoreValue.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            TeamTwoScoreLabel.AutoSize = true;
            TeamTwoScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamTwoScoreLabel.ForeColor = Color.FromArgb(52, 153, 255);
            TeamTwoScoreLabel.Location = new Point(531, 497);
            TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            TeamTwoScoreLabel.Size = new Size(82, 37);
            TeamTwoScoreLabel.TabIndex = 10;
            TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoName
            // 
            TeamTwoName.AutoSize = true;
            TeamTwoName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamTwoName.ForeColor = Color.FromArgb(52, 153, 255);
            TeamTwoName.Location = new Point(531, 432);
            TeamTwoName.Name = "TeamTwoName";
            TeamTwoName.Size = new Size(165, 37);
            TeamTwoName.TabIndex = 9;
            TeamTwoName.Text = "<team two>";
            // 
            // VSLabel
            // 
            VSLabel.AutoSize = true;
            VSLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VSLabel.ForeColor = Color.FromArgb(52, 153, 255);
            VSLabel.Location = new Point(585, 375);
            VSLabel.Name = "VSLabel";
            VSLabel.Size = new Size(70, 37);
            VSLabel.TabIndex = 12;
            VSLabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            ScoreButton.FlatAppearance.BorderColor = Color.Silver;
            ScoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            ScoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            ScoreButton.FlatStyle = FlatStyle.Flat;
            ScoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreButton.ForeColor = SystemColors.MenuHighlight;
            ScoreButton.Location = new Point(789, 366);
            ScoreButton.Name = "ScoreButton";
            ScoreButton.Size = new Size(114, 61);
            ScoreButton.TabIndex = 13;
            ScoreButton.Text = "Score";
            ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(976, 585);
            Controls.Add(ScoreButton);
            Controls.Add(VSLabel);
            Controls.Add(TeamTwoScoreValue);
            Controls.Add(TeamTwoScoreLabel);
            Controls.Add(TeamTwoName);
            Controls.Add(TeamOneScoreValue);
            Controls.Add(TeamOneScoreLabel);
            Controls.Add(TeamOneName);
            Controls.Add(MatchupListBox);
            Controls.Add(UnplayedOnlyCheckbox);
            Controls.Add(RoundDropdown);
            Controls.Add(Round);
            Controls.Add(TounamentName);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label TounamentName;
        private Label Round;
        private ComboBox RoundDropdown;
        private CheckBox UnplayedOnlyCheckbox;
        private ListBox MatchupListBox;
        private Label TeamOneName;
        private Label TeamOneScoreLabel;
        private TextBox TeamOneScoreValue;
        private TextBox TeamTwoScoreValue;
        private Label TeamTwoScoreLabel;
        private Label TeamTwoName;
        private Label VSLabel;
        private Button ScoreButton;
    }
}
