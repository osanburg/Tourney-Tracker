using System.Drawing;
using System.Windows.Forms;

namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.DeleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.TournamentPlayersLabel = new System.Windows.Forms.Label();
            this.TournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.CreateTournamentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateTournamentButton.Location = new System.Drawing.Point(303, 546);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(361, 89);
            this.CreateTournamentButton.TabIndex = 41;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            this.DeleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteSelectedPrizeButton.Location = new System.Drawing.Point(791, 407);
            this.DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            this.DeleteSelectedPrizeButton.Size = new System.Drawing.Size(114, 73);
            this.DeleteSelectedPrizeButton.TabIndex = 40;
            this.DeleteSelectedPrizeButton.Text = "Delete Selected";
            this.DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrizesLabel.Location = new System.Drawing.Point(459, 321);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(85, 37);
            this.PrizesLabel.TabIndex = 39;
            this.PrizesLabel.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 30;
            this.PrizesListBox.Location = new System.Drawing.Point(466, 361);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(302, 152);
            this.PrizesListBox.TabIndex = 38;
            // 
            // DeleteSelectedPlayersButton
            // 
            this.DeleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPlayersButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteSelectedPlayersButton.Location = new System.Drawing.Point(791, 186);
            this.DeleteSelectedPlayersButton.Name = "DeleteSelectedPlayersButton";
            this.DeleteSelectedPlayersButton.Size = new System.Drawing.Size(114, 72);
            this.DeleteSelectedPlayersButton.TabIndex = 37;
            this.DeleteSelectedPlayersButton.Text = "Delete Selected";
            this.DeleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersLabel
            // 
            this.TournamentPlayersLabel.AutoSize = true;
            this.TournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentPlayersLabel.Location = new System.Drawing.Point(459, 100);
            this.TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            this.TournamentPlayersLabel.Size = new System.Drawing.Size(198, 37);
            this.TournamentPlayersLabel.TabIndex = 36;
            this.TournamentPlayersLabel.Text = "Teams / Players";
            // 
            // TournamentTeamsListBox
            // 
            this.TournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentTeamsListBox.FormattingEnabled = true;
            this.TournamentTeamsListBox.ItemHeight = 30;
            this.TournamentTeamsListBox.Location = new System.Drawing.Point(466, 140);
            this.TournamentTeamsListBox.Name = "TournamentTeamsListBox";
            this.TournamentTeamsListBox.Size = new System.Drawing.Size(302, 152);
            this.TournamentTeamsListBox.TabIndex = 35;
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreatePrizeButton.Location = new System.Drawing.Point(83, 461);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(214, 52);
            this.CreatePrizeButton.TabIndex = 34;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddTeamButton.Location = new System.Drawing.Point(83, 386);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(214, 52);
            this.AddTeamButton.TabIndex = 33;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Location = new System.Drawing.Point(224, 296);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(121, 30);
            this.CreateNewTeamLink.TabIndex = 32;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create New";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(34, 329);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(311, 38);
            this.SelectTeamDropDown.TabIndex = 31;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamLabel.Location = new System.Drawing.Point(28, 289);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.SelectTeamLabel.TabIndex = 30;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(165, 224);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(100, 35);
            this.EntryFeeValue.TabIndex = 29;
            this.EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EntryFeeLabel.Location = new System.Drawing.Point(28, 221);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.EntryFeeLabel.TabIndex = 28;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(34, 154);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(311, 35);
            this.TournamentNameValue.TabIndex = 27;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentNameLabel.Location = new System.Drawing.Point(29, 103);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.TournamentNameLabel.TabIndex = 26;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // CreateTournamentLabel
            // 
            this.CreateTournamentLabel.AutoSize = true;
            this.CreateTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.CreateTournamentLabel.Location = new System.Drawing.Point(28, 28);
            this.CreateTournamentLabel.Name = "CreateTournamentLabel";
            this.CreateTournamentLabel.Size = new System.Drawing.Size(317, 50);
            this.CreateTournamentLabel.TabIndex = 25;
            this.CreateTournamentLabel.Text = "Create Tournament";
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 678);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteSelectedPrizeButton);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.DeleteSelectedPlayersButton);
            this.Controls.Add(this.TournamentPlayersLabel);
            this.Controls.Add(this.TournamentTeamsListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.CreateTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreateTournamentButton;
        private Button DeleteSelectedPrizeButton;
        private Label PrizesLabel;
        private ListBox PrizesListBox;
        private Button DeleteSelectedPlayersButton;
        private Label TournamentPlayersLabel;
        private ListBox TournamentTeamsListBox;
        private Button CreatePrizeButton;
        private Button AddTeamButton;
        private LinkLabel CreateNewTeamLink;
        private ComboBox SelectTeamDropDown;
        private Label SelectTeamLabel;
        private TextBox EntryFeeValue;
        private Label EntryFeeLabel;
        private TextBox TournamentNameValue;
        private Label TournamentNameLabel;
        private Label CreateTournamentLabel;
    }
}