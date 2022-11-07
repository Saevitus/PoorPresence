namespace PoorPresence
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
            this.MainConsole = new System.Windows.Forms.RichTextBox();
            this.xD = new System.Windows.Forms.GroupBox();
            this.xD.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainConsole
            // 
            this.MainConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainConsole.Location = new System.Drawing.Point(9, 18);
            this.MainConsole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainConsole.Name = "MainConsole";
            this.MainConsole.Size = new System.Drawing.Size(723, 388);
            this.MainConsole.TabIndex = 0;
            this.MainConsole.Text = "";
            // 
            // xD
            // 
            this.xD.Controls.Add(this.MainConsole);
            this.xD.Location = new System.Drawing.Point(5, 0);
            this.xD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xD.Name = "xD";
            this.xD.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xD.Size = new System.Drawing.Size(742, 415);
            this.xD.TabIndex = 1;
            this.xD.TabStop = false;
            this.xD.Text = "Output";
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.xD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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