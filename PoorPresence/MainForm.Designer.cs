namespace PoorPresence
{
    partial class MainForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.GetAccountInfo = new System.Windows.Forms.Button();
            this.SteamAppID = new System.Windows.Forms.TextBox();
            this.InviteButton = new System.Windows.Forms.Button();
            this.TargetInput = new System.Windows.Forms.TextBox();
            this.ConnectInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UnlockAllAchievements = new System.Windows.Forms.Button();
            this.LockAllAchievements = new System.Windows.Forms.Button();
            this.UnlockSetAchievements = new System.Windows.Forms.Button();
            this.NumOfAchievements = new System.Windows.Forms.TextBox();
            this.RichButton = new System.Windows.Forms.Button();
            this.StatusInput = new System.Windows.Forms.TextBox();
            this.ScoreInput = new System.Windows.Forms.TextBox();
            this.DiscordRPCButton = new System.Windows.Forms.Button();
            this.DiscordAppID = new System.Windows.Forms.TextBox();
            this.SetDCRP = new System.Windows.Forms.Button();
            this.RPLargeImageText = new System.Windows.Forms.TextBox();
            this.RPSmallImageText = new System.Windows.Forms.TextBox();
            this.RPStateText = new System.Windows.Forms.TextBox();
            this.RPDetailsText = new System.Windows.Forms.TextBox();
            this.saveCfg = new System.Windows.Forms.Button();
            this.loadCfg = new System.Windows.Forms.Button();
            this.clearCfg = new System.Windows.Forms.Button();
            this.timestampToggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(5, 5);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AcceptButton.Size = new System.Drawing.Size(84, 51);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // GetAccountInfo
            // 
            this.GetAccountInfo.Location = new System.Drawing.Point(5, 60);
            this.GetAccountInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GetAccountInfo.Name = "GetAccountInfo";
            this.GetAccountInfo.Size = new System.Drawing.Size(154, 51);
            this.GetAccountInfo.TabIndex = 2;
            this.GetAccountInfo.Text = "Get Account Info";
            this.GetAccountInfo.UseVisualStyleBackColor = true;
            this.GetAccountInfo.Click += new System.EventHandler(this.Fuck_Click);
            // 
            // SteamAppID
            // 
            this.SteamAppID.Location = new System.Drawing.Point(93, 28);
            this.SteamAppID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SteamAppID.Name = "SteamAppID";
            this.SteamAppID.Size = new System.Drawing.Size(65, 23);
            this.SteamAppID.TabIndex = 8;
            this.SteamAppID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InviteButton
            // 
            this.InviteButton.Location = new System.Drawing.Point(163, 5);
            this.InviteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InviteButton.Name = "InviteButton";
            this.InviteButton.Size = new System.Drawing.Size(154, 51);
            this.InviteButton.TabIndex = 5;
            this.InviteButton.Text = "Fake Invite";
            this.InviteButton.UseVisualStyleBackColor = true;
            this.InviteButton.Click += new System.EventHandler(this.InviteButton_Click);
            // 
            // TargetInput
            // 
            this.TargetInput.Location = new System.Drawing.Point(163, 60);
            this.TargetInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TargetInput.Name = "TargetInput";
            this.TargetInput.Size = new System.Drawing.Size(153, 23);
            this.TargetInput.TabIndex = 6;
            this.TargetInput.Text = "Target Name";
            this.TargetInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConnectInput
            // 
            this.ConnectInput.Location = new System.Drawing.Point(163, 88);
            this.ConnectInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConnectInput.Name = "ConnectInput";
            this.ConnectInput.Size = new System.Drawing.Size(153, 23);
            this.ConnectInput.TabIndex = 7;
            this.ConnectInput.Text = "Connect String";
            this.ConnectInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set AppID";
            // 
            // UnlockAllAchievements
            // 
            this.UnlockAllAchievements.Location = new System.Drawing.Point(5, 115);
            this.UnlockAllAchievements.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UnlockAllAchievements.Name = "UnlockAllAchievements";
            this.UnlockAllAchievements.Size = new System.Drawing.Size(154, 51);
            this.UnlockAllAchievements.TabIndex = 9;
            this.UnlockAllAchievements.Text = "Get All Achievements";
            this.UnlockAllAchievements.UseVisualStyleBackColor = true;
            this.UnlockAllAchievements.Click += new System.EventHandler(this.UnlockAllAchievements_Click);
            // 
            // LockAllAchievements
            // 
            this.LockAllAchievements.Location = new System.Drawing.Point(163, 115);
            this.LockAllAchievements.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LockAllAchievements.Name = "LockAllAchievements";
            this.LockAllAchievements.Size = new System.Drawing.Size(154, 51);
            this.LockAllAchievements.TabIndex = 10;
            this.LockAllAchievements.Text = "Clear All Achievements";
            this.LockAllAchievements.UseVisualStyleBackColor = true;
            this.LockAllAchievements.Click += new System.EventHandler(this.LockAllAchievements_Click);
            // 
            // UnlockSetAchievements
            // 
            this.UnlockSetAchievements.Location = new System.Drawing.Point(5, 173);
            this.UnlockSetAchievements.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UnlockSetAchievements.Name = "UnlockSetAchievements";
            this.UnlockSetAchievements.Size = new System.Drawing.Size(154, 51);
            this.UnlockSetAchievements.TabIndex = 11;
            this.UnlockSetAchievements.Text = "Unlock Num Achievements";
            this.UnlockSetAchievements.UseVisualStyleBackColor = true;
            this.UnlockSetAchievements.Click += new System.EventHandler(this.UnlockSetAchievements_Click);
            // 
            // NumOfAchievements
            // 
            this.NumOfAchievements.Location = new System.Drawing.Point(5, 231);
            this.NumOfAchievements.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumOfAchievements.Name = "NumOfAchievements";
            this.NumOfAchievements.Size = new System.Drawing.Size(153, 23);
            this.NumOfAchievements.TabIndex = 12;
            // 
            // RichButton
            // 
            this.RichButton.Location = new System.Drawing.Point(322, 5);
            this.RichButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RichButton.Name = "RichButton";
            this.RichButton.Size = new System.Drawing.Size(154, 51);
            this.RichButton.TabIndex = 13;
            this.RichButton.Text = "Set Steam Rich Presence";
            this.RichButton.UseVisualStyleBackColor = true;
            this.RichButton.Click += new System.EventHandler(this.RichButton_Click);
            // 
            // StatusInput
            // 
            this.StatusInput.Location = new System.Drawing.Point(322, 60);
            this.StatusInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StatusInput.Name = "StatusInput";
            this.StatusInput.Size = new System.Drawing.Size(153, 23);
            this.StatusInput.TabIndex = 14;
            this.StatusInput.Text = "Status";
            this.StatusInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScoreInput
            // 
            this.ScoreInput.Location = new System.Drawing.Point(322, 88);
            this.ScoreInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ScoreInput.Name = "ScoreInput";
            this.ScoreInput.Size = new System.Drawing.Size(153, 23);
            this.ScoreInput.TabIndex = 15;
            this.ScoreInput.Text = "Score";
            this.ScoreInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiscordRPCButton
            // 
            this.DiscordRPCButton.Location = new System.Drawing.Point(592, 5);
            this.DiscordRPCButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DiscordRPCButton.Name = "DiscordRPCButton";
            this.DiscordRPCButton.Size = new System.Drawing.Size(154, 51);
            this.DiscordRPCButton.TabIndex = 16;
            this.DiscordRPCButton.Text = "Initialize Discord Rich Presence";
            this.DiscordRPCButton.UseVisualStyleBackColor = true;
            this.DiscordRPCButton.Click += new System.EventHandler(this.DiscordRPCButton_Click);
            // 
            // DiscordAppID
            // 
            this.DiscordAppID.Location = new System.Drawing.Point(592, 62);
            this.DiscordAppID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DiscordAppID.Name = "DiscordAppID";
            this.DiscordAppID.Size = new System.Drawing.Size(153, 23);
            this.DiscordAppID.TabIndex = 17;
            this.DiscordAppID.Text = "AppID";
            this.DiscordAppID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetDCRP
            // 
            this.SetDCRP.Location = new System.Drawing.Point(592, 92);
            this.SetDCRP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SetDCRP.Name = "SetDCRP";
            this.SetDCRP.Size = new System.Drawing.Size(154, 51);
            this.SetDCRP.TabIndex = 18;
            this.SetDCRP.Text = "Set Rich Presence";
            this.SetDCRP.UseVisualStyleBackColor = true;
            this.SetDCRP.Click += new System.EventHandler(this.SetDCRP_Click);
            // 
            // RPLargeImageText
            // 
            this.RPLargeImageText.Location = new System.Drawing.Point(592, 210);
            this.RPLargeImageText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RPLargeImageText.Name = "RPLargeImageText";
            this.RPLargeImageText.Size = new System.Drawing.Size(153, 23);
            this.RPLargeImageText.TabIndex = 19;
            this.RPLargeImageText.Text = "Large Image";
            this.RPLargeImageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RPSmallImageText
            // 
            this.RPSmallImageText.Location = new System.Drawing.Point(592, 240);
            this.RPSmallImageText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RPSmallImageText.Name = "RPSmallImageText";
            this.RPSmallImageText.Size = new System.Drawing.Size(153, 23);
            this.RPSmallImageText.TabIndex = 20;
            this.RPSmallImageText.Text = "Small Image";
            this.RPSmallImageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RPStateText
            // 
            this.RPStateText.Location = new System.Drawing.Point(592, 180);
            this.RPStateText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RPStateText.Name = "RPStateText";
            this.RPStateText.Size = new System.Drawing.Size(153, 23);
            this.RPStateText.TabIndex = 21;
            this.RPStateText.Text = "State";
            this.RPStateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RPDetailsText
            // 
            this.RPDetailsText.Location = new System.Drawing.Point(592, 150);
            this.RPDetailsText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RPDetailsText.Name = "RPDetailsText";
            this.RPDetailsText.Size = new System.Drawing.Size(153, 23);
            this.RPDetailsText.TabIndex = 22;
            this.RPDetailsText.Text = "Details";
            this.RPDetailsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveCfg
            // 
            this.saveCfg.Location = new System.Drawing.Point(5, 355);
            this.saveCfg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveCfg.Name = "saveCfg";
            this.saveCfg.Size = new System.Drawing.Size(154, 51);
            this.saveCfg.TabIndex = 23;
            this.saveCfg.Text = "Save Default Config";
            this.saveCfg.UseVisualStyleBackColor = true;
            this.saveCfg.Click += new System.EventHandler(this.saveCfg_Click);
            // 
            // loadCfg
            // 
            this.loadCfg.Location = new System.Drawing.Point(167, 355);
            this.loadCfg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loadCfg.Name = "loadCfg";
            this.loadCfg.Size = new System.Drawing.Size(154, 51);
            this.loadCfg.TabIndex = 24;
            this.loadCfg.Text = "Load Config";
            this.loadCfg.UseVisualStyleBackColor = true;
            this.loadCfg.Click += new System.EventHandler(this.loadCfg_Click);
            // 
            // clearCfg
            // 
            this.clearCfg.Location = new System.Drawing.Point(329, 355);
            this.clearCfg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearCfg.Name = "clearCfg";
            this.clearCfg.Size = new System.Drawing.Size(154, 51);
            this.clearCfg.TabIndex = 25;
            this.clearCfg.Text = "Clear Config";
            this.clearCfg.UseVisualStyleBackColor = true;
            this.clearCfg.Click += new System.EventHandler(this.clearCfg_Click);
            // 
            // timestampToggle
            // 
            this.timestampToggle.Location = new System.Drawing.Point(592, 269);
            this.timestampToggle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.timestampToggle.Name = "timestampToggle";
            this.timestampToggle.Size = new System.Drawing.Size(154, 51);
            this.timestampToggle.TabIndex = 26;
            this.timestampToggle.Text = "Toggle Timestamp";
            this.timestampToggle.UseVisualStyleBackColor = true;
            this.timestampToggle.Click += new System.EventHandler(this.timestampToggle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.timestampToggle);
            this.Controls.Add(this.clearCfg);
            this.Controls.Add(this.loadCfg);
            this.Controls.Add(this.saveCfg);
            this.Controls.Add(this.RPDetailsText);
            this.Controls.Add(this.RPStateText);
            this.Controls.Add(this.RPSmallImageText);
            this.Controls.Add(this.RPLargeImageText);
            this.Controls.Add(this.SetDCRP);
            this.Controls.Add(this.DiscordAppID);
            this.Controls.Add(this.DiscordRPCButton);
            this.Controls.Add(this.ScoreInput);
            this.Controls.Add(this.StatusInput);
            this.Controls.Add(this.RichButton);
            this.Controls.Add(this.NumOfAchievements);
            this.Controls.Add(this.UnlockSetAchievements);
            this.Controls.Add(this.LockAllAchievements);
            this.Controls.Add(this.UnlockAllAchievements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectInput);
            this.Controls.Add(this.TargetInput);
            this.Controls.Add(this.InviteButton);
            this.Controls.Add(this.SteamAppID);
            this.Controls.Add(this.GetAccountInfo);
            this.Controls.Add(this.AcceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "PoorPresence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button GetAccountInfo;
        private System.Windows.Forms.TextBox SteamAppID;
        private System.Windows.Forms.Button InviteButton;
        private System.Windows.Forms.TextBox TargetInput;
        private System.Windows.Forms.TextBox ConnectInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UnlockAllAchievements;
        private System.Windows.Forms.Button LockAllAchievements;
        private System.Windows.Forms.Button UnlockSetAchievements;
        private System.Windows.Forms.TextBox NumOfAchievements;
        private System.Windows.Forms.Button RichButton;
        private System.Windows.Forms.TextBox StatusInput;
        private System.Windows.Forms.TextBox ScoreInput;
        private System.Windows.Forms.Button DiscordRPCButton;
        private System.Windows.Forms.TextBox DiscordAppID;
        private System.Windows.Forms.Button SetDCRP;
        private System.Windows.Forms.TextBox RPLargeImageText;
        private System.Windows.Forms.TextBox RPSmallImageText;
        private System.Windows.Forms.TextBox RPStateText;
        private System.Windows.Forms.TextBox RPDetailsText;
        private Button saveCfg;
        private Button loadCfg;
        private Button clearCfg;
        private Button timestampToggle;
    }
}
