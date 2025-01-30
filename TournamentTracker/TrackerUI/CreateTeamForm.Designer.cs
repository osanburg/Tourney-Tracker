namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            TeamNameValue = new TextBox();
            TeamNameLabel = new Label();
            CreateTeamLabel = new Label();
            AddMemberButton = new Button();
            SelectTeamMemberDropDown = new ComboBox();
            SelectTeamMemberLabel = new Label();
            AddNewMemberBox = new GroupBox();
            FirstNameValue = new TextBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            LastNameValue = new TextBox();
            EmailLabel = new Label();
            EmailValue = new TextBox();
            PhoneNumberLabel = new Label();
            PhoneNumberValue = new TextBox();
            CreateMemberButton = new Button();
            TeamMembersListBox = new ListBox();
            DeleteSelectedMemberButton = new Button();
            CreateTeamButton = new Button();
            AddNewMemberBox.SuspendLayout();
            SuspendLayout();
            // 
            // TeamNameValue
            // 
            TeamNameValue.Location = new Point(30, 152);
            TeamNameValue.Name = "TeamNameValue";
            TeamNameValue.Size = new Size(405, 35);
            TeamNameValue.TabIndex = 13;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamNameLabel.ForeColor = Color.FromArgb(52, 153, 255);
            TeamNameLabel.Location = new Point(25, 101);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(157, 37);
            TeamNameLabel.TabIndex = 12;
            TeamNameLabel.Text = "Team Name";
            // 
            // CreateTeamLabel
            // 
            CreateTeamLabel.AutoSize = true;
            CreateTeamLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateTeamLabel.ForeColor = Color.FromArgb(51, 155, 255);
            CreateTeamLabel.Location = new Point(24, 26);
            CreateTeamLabel.Name = "CreateTeamLabel";
            CreateTeamLabel.Size = new Size(213, 50);
            CreateTeamLabel.TabIndex = 11;
            CreateTeamLabel.Text = "Create Team";
            // 
            // AddMemberButton
            // 
            AddMemberButton.FlatAppearance.BorderColor = Color.Silver;
            AddMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            AddMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AddMemberButton.FlatStyle = FlatStyle.Flat;
            AddMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMemberButton.ForeColor = SystemColors.MenuHighlight;
            AddMemberButton.Location = new Point(127, 322);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(214, 52);
            AddMemberButton.TabIndex = 19;
            AddMemberButton.Text = "Add Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamMemberDropDown
            // 
            SelectTeamMemberDropDown.FormattingEnabled = true;
            SelectTeamMemberDropDown.Location = new Point(36, 257);
            SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            SelectTeamMemberDropDown.Size = new Size(405, 38);
            SelectTeamMemberDropDown.TabIndex = 18;
            // 
            // SelectTeamMemberLabel
            // 
            SelectTeamMemberLabel.AutoSize = true;
            SelectTeamMemberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectTeamMemberLabel.ForeColor = Color.FromArgb(52, 153, 255);
            SelectTeamMemberLabel.Location = new Point(30, 217);
            SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            SelectTeamMemberLabel.Size = new Size(263, 37);
            SelectTeamMemberLabel.TabIndex = 17;
            SelectTeamMemberLabel.Text = "Select Team Member";
            // 
            // AddNewMemberBox
            // 
            AddNewMemberBox.Controls.Add(CreateMemberButton);
            AddNewMemberBox.Controls.Add(PhoneNumberValue);
            AddNewMemberBox.Controls.Add(PhoneNumberLabel);
            AddNewMemberBox.Controls.Add(EmailValue);
            AddNewMemberBox.Controls.Add(EmailLabel);
            AddNewMemberBox.Controls.Add(LastNameValue);
            AddNewMemberBox.Controls.Add(LastNameLabel);
            AddNewMemberBox.Controls.Add(FirstNameValue);
            AddNewMemberBox.Controls.Add(FirstNameLabel);
            AddNewMemberBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewMemberBox.ForeColor = SystemColors.MenuHighlight;
            AddNewMemberBox.Location = new Point(36, 406);
            AddNewMemberBox.Name = "AddNewMemberBox";
            AddNewMemberBox.Size = new Size(399, 353);
            AddNewMemberBox.TabIndex = 20;
            AddNewMemberBox.TabStop = false;
            AddNewMemberBox.Text = "Add New Member ";
            AddNewMemberBox.Enter += AddNewMemberBox_Enter;
            // 
            // FirstNameValue
            // 
            FirstNameValue.Location = new Point(166, 57);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(194, 43);
            FirstNameValue.TabIndex = 10;
            FirstNameValue.TextChanged += TeamOneScoreValue_TextChanged;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameLabel.ForeColor = Color.FromArgb(52, 153, 255);
            FirstNameLabel.Location = new Point(16, 54);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(144, 37);
            FirstNameLabel.TabIndex = 9;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameLabel.ForeColor = Color.FromArgb(52, 153, 255);
            LastNameLabel.Location = new Point(16, 108);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(142, 37);
            LastNameLabel.TabIndex = 11;
            LastNameLabel.Text = "Last Name";
            // 
            // LastNameValue
            // 
            LastNameValue.Location = new Point(166, 111);
            LastNameValue.Name = "LastNameValue";
            LastNameValue.Size = new Size(194, 43);
            LastNameValue.TabIndex = 12;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = Color.FromArgb(52, 153, 255);
            EmailLabel.Location = new Point(18, 158);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(82, 37);
            EmailLabel.TabIndex = 13;
            EmailLabel.Text = "Email";
            // 
            // EmailValue
            // 
            EmailValue.Location = new Point(166, 161);
            EmailValue.Name = "EmailValue";
            EmailValue.Size = new Size(194, 43);
            EmailValue.TabIndex = 14;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneNumberLabel.ForeColor = Color.FromArgb(52, 153, 255);
            PhoneNumberLabel.Location = new Point(18, 207);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(115, 37);
            PhoneNumberLabel.TabIndex = 15;
            PhoneNumberLabel.Text = "Phone #";
            PhoneNumberLabel.Click += PhoneNumberLabel_Click;
            // 
            // PhoneNumberValue
            // 
            PhoneNumberValue.Location = new Point(166, 210);
            PhoneNumberValue.Name = "PhoneNumberValue";
            PhoneNumberValue.Size = new Size(194, 43);
            PhoneNumberValue.TabIndex = 16;
            // 
            // CreateMemberButton
            // 
            CreateMemberButton.FlatAppearance.BorderColor = Color.Silver;
            CreateMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateMemberButton.FlatStyle = FlatStyle.Flat;
            CreateMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateMemberButton.ForeColor = SystemColors.MenuHighlight;
            CreateMemberButton.Location = new Point(91, 277);
            CreateMemberButton.Name = "CreateMemberButton";
            CreateMemberButton.Size = new Size(214, 52);
            CreateMemberButton.TabIndex = 20;
            CreateMemberButton.Text = "CreateMember";
            CreateMemberButton.UseVisualStyleBackColor = true;
            // 
            // TeamMembersListBox
            // 
            TeamMembersListBox.FormattingEnabled = true;
            TeamMembersListBox.ItemHeight = 30;
            TeamMembersListBox.Location = new Point(501, 152);
            TeamMembersListBox.Name = "TeamMembersListBox";
            TeamMembersListBox.Size = new Size(360, 604);
            TeamMembersListBox.TabIndex = 21;
            // 
            // DeleteSelectedMemberButton
            // 
            DeleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedMemberButton.ForeColor = SystemColors.MenuHighlight;
            DeleteSelectedMemberButton.Location = new Point(875, 406);
            DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            DeleteSelectedMemberButton.Size = new Size(114, 72);
            DeleteSelectedMemberButton.TabIndex = 22;
            DeleteSelectedMemberButton.Text = "Delete Selected";
            DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTeamButton.FlatStyle = FlatStyle.Flat;
            CreateTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTeamButton.ForeColor = SystemColors.MenuHighlight;
            CreateTeamButton.Location = new Point(273, 783);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(467, 106);
            CreateTeamButton.TabIndex = 23;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1001, 901);
            Controls.Add(CreateTeamButton);
            Controls.Add(DeleteSelectedMemberButton);
            Controls.Add(TeamMembersListBox);
            Controls.Add(AddNewMemberBox);
            Controls.Add(AddMemberButton);
            Controls.Add(SelectTeamMemberDropDown);
            Controls.Add(SelectTeamMemberLabel);
            Controls.Add(TeamNameValue);
            Controls.Add(TeamNameLabel);
            Controls.Add(CreateTeamLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            Load += CreateTeamForm_Load;
            AddNewMemberBox.ResumeLayout(false);
            AddNewMemberBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TeamNameValue;
        private Label TeamNameLabel;
        private Label CreateTeamLabel;
        private Button AddMemberButton;
        private ComboBox SelectTeamMemberDropDown;
        private Label SelectTeamMemberLabel;
        private GroupBox AddNewMemberBox;
        private TextBox FirstNameValue;
        private Label FirstNameLabel;
        private TextBox LastNameValue;
        private Label LastNameLabel;
        private TextBox EmailValue;
        private Label EmailLabel;
        private TextBox PhoneNumberValue;
        private Label PhoneNumberLabel;
        private Button CreateMemberButton;
        private ListBox TeamMembersListBox;
        private Button DeleteSelectedMemberButton;
        private Button CreateTeamButton;
    }
}