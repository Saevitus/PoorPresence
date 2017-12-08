namespace SteamShit.Main
{
	partial class Console
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Console));
			this.MainConsole = new System.Windows.Forms.RichTextBox();
			this.xD = new System.Windows.Forms.GroupBox();
			this.xD.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainConsole
			// 
			this.MainConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.MainConsole.Location = new System.Drawing.Point(8, 16);
			this.MainConsole.Name = "MainConsole";
			this.MainConsole.Size = new System.Drawing.Size(620, 336);
			this.MainConsole.TabIndex = 0;
			this.MainConsole.Text = "";
			// 
			// xD
			// 
			this.xD.Controls.Add(this.MainConsole);
			this.xD.Location = new System.Drawing.Point(4, 0);
			this.xD.Name = "xD";
			this.xD.Size = new System.Drawing.Size(636, 360);
			this.xD.TabIndex = 1;
			this.xD.TabStop = false;
			this.xD.Text = "Output";
			// 
			// Console
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 362);
			this.ControlBox = false;
			this.Controls.Add(this.xD);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Console";
			this.Text = "Console";
			this.xD.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.RichTextBox MainConsole;
		private System.Windows.Forms.GroupBox xD;
	}
}