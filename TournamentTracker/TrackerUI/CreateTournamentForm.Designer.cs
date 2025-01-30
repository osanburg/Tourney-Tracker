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
            CreateTournamentLabel = new Label();
            TournamentNameValue = new TextBox();
            TournamentNameLabel = new Label();
            EntryFeeValue = new TextBox();
            EntryFeeLabel = new Label();
            SelectTeamDropDown = new ComboBox();
            SelectTeamLabel = new Label();
            CreateNewTeamLink = new LinkLabel();
            AddTeamButton = new Button();
            CreatePrizeButton = new Button();
            TournamentPlayersListBox = new ListBox();
            TournamentPlayersLabel = new Label();
            DeleteSelectedPlayersButton = new Button();
            DeleteSelectedPrizeButton = new Button();
            PrizesLabel = new Label();
            PrizesListBox = new ListBox();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // CreateTournamentLabel
            // 
            CreateTournamentLabel.AutoSize = true;
            CreateTournamentLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateTournamentLabel.ForeColor = Color.FromArgb(51, 155, 255);
            CreateTournamentLabel.Location = new Point(27, 28);
            CreateTournamentLabel.Name = "CreateTournamentLabel";
            CreateTournamentLabel.Size = new Size(317, 50);
            CreateTournamentLabel.TabIndex = 1;
            CreateTournamentLabel.Text = "Create Tournament";
            // 
            // TournamentNameValue
            // 
            TournamentNameValue.Location = new Point(33, 154);
            TournamentNameValue.Name = "TournamentNameValue";
            TournamentNameValue.Size = new Size(311, 35);
            TournamentNameValue.TabIndex = 10;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentNameLabel.ForeColor = Color.FromArgb(52, 153, 255);
            TournamentNameLabel.Location = new Point(28, 103);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(236, 37);
            TournamentNameLabel.TabIndex = 9;
            TournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            EntryFeeValue.Location = new Point(164, 224);
            EntryFeeValue.Name = "EntryFeeValue";
            EntryFeeValue.Size = new Size(100, 35);
            EntryFeeValue.TabIndex = 12;
            EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            EntryFeeLabel.AutoSize = true;
            EntryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EntryFeeLabel.ForeColor = Color.FromArgb(52, 153, 255);
            EntryFeeLabel.Location = new Point(27, 221);
            EntryFeeLabel.Name = "EntryFeeLabel";
            EntryFeeLabel.Size = new Size(125, 37);
            EntryFeeLabel.TabIndex = 11;
            EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            SelectTeamDropDown.FormattingEnabled = true;
            SelectTeamDropDown.Location = new Point(33, 329);
            SelectTeamDropDown.Name = "SelectTeamDropDown";
            SelectTeamDropDown.Size = new Size(311, 38);
            SelectTeamDropDown.TabIndex = 14;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectTeamLabel.ForeColor = Color.FromArgb(52, 153, 255);
            SelectTeamLabel.Location = new Point(27, 289);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(156, 37);
            SelectTeamLabel.TabIndex = 13;
            SelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewTeamLink
            // 
            CreateNewTeamLink.AutoSize = true;
            CreateNewTeamLink.Location = new Point(223, 296);
            CreateNewTeamLink.Name = "CreateNewTeamLink";
            CreateNewTeamLink.Size = new Size(121, 30);
            CreateNewTeamLink.TabIndex = 15;
            CreateNewTeamLink.TabStop = true;
            CreateNewTeamLink.Text = "Create New";
            CreateNewTeamLink.LinkClicked += CreateNewTeamLink_LinkClicked;
            // 
            // AddTeamButton
            // 
            AddTeamButton.FlatAppearance.BorderColor = Color.Silver;
            AddTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            AddTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AddTeamButton.FlatStyle = FlatStyle.Flat;
            AddTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTeamButton.ForeColor = SystemColors.MenuHighlight;
            AddTeamButton.Location = new Point(82, 386);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(214, 52);
            AddTeamButton.TabIndex = 16;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeButton.ForeColor = SystemColors.MenuHighlight;
            CreatePrizeButton.Location = new Point(82, 461);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(214, 52);
            CreatePrizeButton.TabIndex = 17;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListBox
            // 
            TournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentPlayersListBox.FormattingEnabled = true;
            TournamentPlayersListBox.ItemHeight = 30;
            TournamentPlayersListBox.Location = new Point(465, 140);
            TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            TournamentPlayersListBox.Size = new Size(302, 152);
            TournamentPlayersListBox.TabIndex = 18;
            // 
            // TournamentPlayersLabel
            // 
            TournamentPlayersLabel.AutoSize = true;
            TournamentPlayersLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentPlayersLabel.ForeColor = Color.FromArgb(52, 153, 255);
            TournamentPlayersLabel.Location = new Point(465, 103);
            TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            TournamentPlayersLabel.Size = new Size(198, 37);
            TournamentPlayersLabel.TabIndex = 19;
            TournamentPlayersLabel.Text = "Teams / Players";
            // 
            // DeleteSelectedPlayersButton
            // 
            DeleteSelectedPlayersButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPlayersButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedPlayersButton.ForeColor = SystemColors.MenuHighlight;
            DeleteSelectedPlayersButton.Location = new Point(790, 186);
            DeleteSelectedPlayersButton.Name = "DeleteSelectedPlayersButton";
            DeleteSelectedPlayersButton.Size = new Size(114, 72);
            DeleteSelectedPlayersButton.TabIndex = 20;
            DeleteSelectedPlayersButton.Text = "Delete Selected";
            DeleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            DeleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedPrizeButton.ForeColor = SystemColors.MenuHighlight;
            DeleteSelectedPrizeButton.Location = new Point(790, 407);
            DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            DeleteSelectedPrizeButton.Size = new Size(114, 73);
            DeleteSelectedPrizeButton.TabIndex = 23;
            DeleteSelectedPrizeButton.Text = "Delete Selected";
            DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrizesLabel.ForeColor = Color.FromArgb(52, 153, 255);
            PrizesLabel.Location = new Point(465, 324);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.Size = new Size(198, 37);
            PrizesLabel.TabIndex = 22;
            PrizesLabel.Text = "Teams / Players";
            // 
            // PrizesListBox
            // 
            PrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 30;
            PrizesListBox.Location = new Point(465, 361);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(302, 152);
            PrizesListBox.TabIndex = 21;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentButton.ForeColor = SystemColors.MenuHighlight;
            CreateTournamentButton.Location = new Point(302, 546);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(361, 89);
            CreateTournamentButton.TabIndex = 24;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(935, 661);
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
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTournamentLabel;
        private TextBox TournamentNameValue;
        private Label TournamentNameLabel;
        private TextBox EntryFeeValue;
        private Label EntryFeeLabel;
        private ComboBox SelectTeamDropDown;
        private Label SelectTeamLabel;
        private LinkLabel CreateNewTeamLink;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private ListBox TournamentPlayersListBox;
        private Label TournamentPlayersLabel;
        private Button DeleteSelectedPlayersButton;
        private Button DeleteSelectedPrizeButton;
        private Label PrizesLabel;
        private ListBox PrizesListBox;
        private Button CreateTournamentButton;
    }
}