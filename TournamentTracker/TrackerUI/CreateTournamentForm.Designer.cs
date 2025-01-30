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
            CreateTournamentButton = new Button();
            DeleteSelectedPrizeButton = new Button();
            PrizesLabel = new Label();
            PrizesListBox = new ListBox();
            DeleteSelectedPlayersButton = new Button();
            TournamentPlayersLabel = new Label();
            TournamentPlayersListBox = new ListBox();
            CreatePrizeButton = new Button();
            AddTeamButton = new Button();
            CreateNewTeamLink = new LinkLabel();
            SelectTeamDropDown = new ComboBox();
            SelectTeamLabel = new Label();
            EntryFeeValue = new TextBox();
            EntryFeeLabel = new Label();
            TournamentNameValue = new TextBox();
            TournamentNameLabel = new Label();
            CreateTournamentLabel = new Label();
            SuspendLayout();
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentButton.ForeColor = SystemColors.MenuHighlight;
            CreateTournamentButton.Location = new Point(303, 546);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(361, 89);
            CreateTournamentButton.TabIndex = 41;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            DeleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedPrizeButton.ForeColor = SystemColors.MenuHighlight;
            DeleteSelectedPrizeButton.Location = new Point(791, 407);
            DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            DeleteSelectedPrizeButton.Size = new Size(114, 73);
            DeleteSelectedPrizeButton.TabIndex = 40;
            DeleteSelectedPrizeButton.Text = "Delete Selected";
            DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrizesLabel.ForeColor = Color.FromArgb(52, 153, 255);
            PrizesLabel.Location = new Point(466, 324);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.Size = new Size(198, 37);
            PrizesLabel.TabIndex = 39;
            PrizesLabel.Text = "Teams / Players";
            // 
            // PrizesListBox
            // 
            PrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 30;
            PrizesListBox.Location = new Point(466, 361);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(302, 152);
            PrizesListBox.TabIndex = 38;
            // 
            // DeleteSelectedPlayersButton
            // 
            DeleteSelectedPlayersButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPlayersButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedPlayersButton.ForeColor = SystemColors.MenuHighlight;
            DeleteSelectedPlayersButton.Location = new Point(791, 186);
            DeleteSelectedPlayersButton.Name = "DeleteSelectedPlayersButton";
            DeleteSelectedPlayersButton.Size = new Size(114, 72);
            DeleteSelectedPlayersButton.TabIndex = 37;
            DeleteSelectedPlayersButton.Text = "Delete Selected";
            DeleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersLabel
            // 
            TournamentPlayersLabel.AutoSize = true;
            TournamentPlayersLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentPlayersLabel.ForeColor = Color.FromArgb(52, 153, 255);
            TournamentPlayersLabel.Location = new Point(466, 103);
            TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            TournamentPlayersLabel.Size = new Size(198, 37);
            TournamentPlayersLabel.TabIndex = 36;
            TournamentPlayersLabel.Text = "Teams / Players";
            // 
            // TournamentPlayersListBox
            // 
            TournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentPlayersListBox.FormattingEnabled = true;
            TournamentPlayersListBox.ItemHeight = 30;
            TournamentPlayersListBox.Location = new Point(466, 140);
            TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            TournamentPlayersListBox.Size = new Size(302, 152);
            TournamentPlayersListBox.TabIndex = 35;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeButton.ForeColor = SystemColors.MenuHighlight;
            CreatePrizeButton.Location = new Point(83, 461);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(214, 52);
            CreatePrizeButton.TabIndex = 34;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // AddTeamButton
            // 
            AddTeamButton.FlatAppearance.BorderColor = Color.Silver;
            AddTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            AddTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AddTeamButton.FlatStyle = FlatStyle.Flat;
            AddTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTeamButton.ForeColor = SystemColors.MenuHighlight;
            AddTeamButton.Location = new Point(83, 386);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(214, 52);
            AddTeamButton.TabIndex = 33;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateNewTeamLink
            // 
            CreateNewTeamLink.AutoSize = true;
            CreateNewTeamLink.Location = new Point(224, 296);
            CreateNewTeamLink.Name = "CreateNewTeamLink";
            CreateNewTeamLink.Size = new Size(121, 30);
            CreateNewTeamLink.TabIndex = 32;
            CreateNewTeamLink.TabStop = true;
            CreateNewTeamLink.Text = "Create New";
            // 
            // SelectTeamDropDown
            // 
            SelectTeamDropDown.FormattingEnabled = true;
            SelectTeamDropDown.Location = new Point(34, 329);
            SelectTeamDropDown.Name = "SelectTeamDropDown";
            SelectTeamDropDown.Size = new Size(311, 38);
            SelectTeamDropDown.TabIndex = 31;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectTeamLabel.ForeColor = Color.FromArgb(52, 153, 255);
            SelectTeamLabel.Location = new Point(28, 289);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(156, 37);
            SelectTeamLabel.TabIndex = 30;
            SelectTeamLabel.Text = "Select Team";
            // 
            // EntryFeeValue
            // 
            EntryFeeValue.Location = new Point(165, 224);
            EntryFeeValue.Name = "EntryFeeValue";
            EntryFeeValue.Size = new Size(100, 35);
            EntryFeeValue.TabIndex = 29;
            EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            EntryFeeLabel.AutoSize = true;
            EntryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EntryFeeLabel.ForeColor = Color.FromArgb(52, 153, 255);
            EntryFeeLabel.Location = new Point(28, 221);
            EntryFeeLabel.Name = "EntryFeeLabel";
            EntryFeeLabel.Size = new Size(125, 37);
            EntryFeeLabel.TabIndex = 28;
            EntryFeeLabel.Text = "Entry Fee";
            // 
            // TournamentNameValue
            // 
            TournamentNameValue.Location = new Point(34, 154);
            TournamentNameValue.Name = "TournamentNameValue";
            TournamentNameValue.Size = new Size(311, 35);
            TournamentNameValue.TabIndex = 27;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentNameLabel.ForeColor = Color.FromArgb(52, 153, 255);
            TournamentNameLabel.Location = new Point(29, 103);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(236, 37);
            TournamentNameLabel.TabIndex = 26;
            TournamentNameLabel.Text = "Tournament Name";
            // 
            // CreateTournamentLabel
            // 
            CreateTournamentLabel.AutoSize = true;
            CreateTournamentLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateTournamentLabel.ForeColor = Color.FromArgb(51, 155, 255);
            CreateTournamentLabel.Location = new Point(28, 28);
            CreateTournamentLabel.Name = "CreateTournamentLabel";
            CreateTournamentLabel.Size = new Size(317, 50);
            CreateTournamentLabel.TabIndex = 25;
            CreateTournamentLabel.Text = "Create Tournament";
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(958, 678);
            Controls.Add(CreateTournamentButton);
            Controls.Add(DeleteSelectedPrizeButton);
            Controls.Add(PrizesLabel);
            Controls.Add(PrizesListBox);
            Controls.Add(DeleteSelectedPlayersButton);
            Controls.Add(TournamentPlayersLabel);
            Controls.Add(TournamentPlayersListBox);
            Controls.Add(CreatePrizeButton);
            Controls.Add(AddTeamButton);
            Controls.Add(CreateNewTeamLink);
            Controls.Add(SelectTeamDropDown);
            Controls.Add(SelectTeamLabel);
            Controls.Add(EntryFeeValue);
            Controls.Add(EntryFeeLabel);
            Controls.Add(TournamentNameValue);
            Controls.Add(TournamentNameLabel);
            Controls.Add(CreateTournamentLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateTournamentButton;
        private Button DeleteSelectedPrizeButton;
        private Label PrizesLabel;
        private ListBox PrizesListBox;
        private Button DeleteSelectedPlayersButton;
        private Label TournamentPlayersLabel;
        private ListBox TournamentPlayersListBox;
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