namespace SteamShit.Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.SuspendLayout();
			// 
			// AcceptButton
			// 
			this.AcceptButton.Location = new System.Drawing.Point(4, 4);
			this.AcceptButton.Name = "AcceptButton";
			this.AcceptButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.AcceptButton.Size = new System.Drawing.Size(72, 44);
			this.AcceptButton.TabIndex = 1;
			this.AcceptButton.Text = "Accept";
			this.AcceptButton.UseVisualStyleBackColor = true;
			this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
			// 
			// GetAccountInfo
			// 
			this.GetAccountInfo.Location = new System.Drawing.Point(4, 52);
			this.GetAccountInfo.Name = "GetAccountInfo";
			this.GetAccountInfo.Size = new System.Drawing.Size(132, 44);
			this.GetAccountInfo.TabIndex = 2;
			this.GetAccountInfo.Text = "Get Account Info";
			this.GetAccountInfo.UseVisualStyleBackColor = true;
			this.GetAccountInfo.Click += new System.EventHandler(this.Fuck_Click);
			// 
			// SteamAppID
			// 
			this.SteamAppID.Location = new System.Drawing.Point(80, 24);
			this.SteamAppID.Name = "SteamAppID";
			this.SteamAppID.Size = new System.Drawing.Size(56, 20);
			this.SteamAppID.TabIndex = 8;
			this.SteamAppID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// InviteButton
			// 
			this.InviteButton.Location = new System.Drawing.Point(140, 4);
			this.InviteButton.Name = "InviteButton";
			this.InviteButton.Size = new System.Drawing.Size(132, 44);
			this.InviteButton.TabIndex = 5;
			this.InviteButton.Text = "Fake Invite";
			this.InviteButton.UseVisualStyleBackColor = true;
			this.InviteButton.Click += new System.EventHandler(this.InviteButton_Click);
			// 
			// TargetInput
			// 
			this.TargetInput.Location = new System.Drawing.Point(140, 52);
			this.TargetInput.Name = "TargetInput";
			this.TargetInput.Size = new System.Drawing.Size(132, 20);
			this.TargetInput.TabIndex = 6;
			this.TargetInput.Text = "Target Name";
			this.TargetInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ConnectInput
			// 
			this.ConnectInput.Location = new System.Drawing.Point(140, 76);
			this.ConnectInput.Name = "ConnectInput";
			this.ConnectInput.Size = new System.Drawing.Size(132, 20);
			this.ConnectInput.TabIndex = 7;
			this.ConnectInput.Text = "Connect String";
			this.ConnectInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(80, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Set AppID";
			// 
			// UnlockAllAchievements
			// 
			this.UnlockAllAchievements.Location = new System.Drawing.Point(4, 100);
			this.UnlockAllAchievements.Name = "UnlockAllAchievements";
			this.UnlockAllAchievements.Size = new System.Drawing.Size(132, 44);
			this.UnlockAllAchievements.TabIndex = 9;
			this.UnlockAllAchievements.Text = "Get All Achievements";
			this.UnlockAllAchievements.UseVisualStyleBackColor = true;
			this.UnlockAllAchievements.Click += new System.EventHandler(this.UnlockAllAchievements_Click);
			// 
			// LockAllAchievements
			// 
			this.LockAllAchievements.Location = new System.Drawing.Point(140, 100);
			this.LockAllAchievements.Name = "LockAllAchievements";
			this.LockAllAchievements.Size = new System.Drawing.Size(132, 44);
			this.LockAllAchievements.TabIndex = 10;
			this.LockAllAchievements.Text = "Clear All Achievements";
			this.LockAllAchievements.UseVisualStyleBackColor = true;
			this.LockAllAchievements.Click += new System.EventHandler(this.LockAllAchievements_Click);
			// 
			// UnlockSetAchievements
			// 
			this.UnlockSetAchievements.Location = new System.Drawing.Point(4, 150);
			this.UnlockSetAchievements.Name = "UnlockSetAchievements";
			this.UnlockSetAchievements.Size = new System.Drawing.Size(132, 44);
			this.UnlockSetAchievements.TabIndex = 11;
			this.UnlockSetAchievements.Text = "Unlock Num Achievements";
			this.UnlockSetAchievements.UseVisualStyleBackColor = true;
			this.UnlockSetAchievements.Click += new System.EventHandler(this.UnlockSetAchievements_Click);
			// 
			// NumOfAchievements
			// 
			this.NumOfAchievements.Location = new System.Drawing.Point(4, 200);
			this.NumOfAchievements.Name = "NumOfAchievements";
			this.NumOfAchievements.Size = new System.Drawing.Size(132, 20);
			this.NumOfAchievements.TabIndex = 12;
			// 
			// RichButton
			// 
			this.RichButton.Location = new System.Drawing.Point(276, 4);
			this.RichButton.Name = "RichButton";
			this.RichButton.Size = new System.Drawing.Size(132, 44);
			this.RichButton.TabIndex = 13;
			this.RichButton.Text = "Set Rich Presence";
			this.RichButton.UseVisualStyleBackColor = true;
			this.RichButton.Click += new System.EventHandler(this.RichButton_Click);
			// 
			// StatusInput
			// 
			this.StatusInput.Location = new System.Drawing.Point(276, 52);
			this.StatusInput.Name = "StatusInput";
			this.StatusInput.Size = new System.Drawing.Size(132, 20);
			this.StatusInput.TabIndex = 14;
			this.StatusInput.Text = "Status";
			this.StatusInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ScoreInput
			// 
			this.ScoreInput.Location = new System.Drawing.Point(276, 76);
			this.ScoreInput.Name = "ScoreInput";
			this.ScoreInput.Size = new System.Drawing.Size(132, 20);
			this.ScoreInput.TabIndex = 15;
			this.ScoreInput.Text = "Score";
			this.ScoreInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 362);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "SteamShit";
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
	}
}
