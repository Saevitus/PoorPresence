using System;
using System.IO;
using System.Windows.Forms;
using Utilities;

namespace SteamShit.Main
{

	public partial class MainForm : Form
	{
		bool m_gbIsSteamInitiated = false;

		// global "Console" class instance
		// which we can use to interact with the 
		// RichTextBox that we have added to the form
		Console m_gConsole;

		// just a global instance of StreamWriter
		// look it up lol
		StreamWriter m_gWriter;
	

		public MainForm()
		{
			InitializeComponent();

			// creating the new instance of our console form
			// and supplying it with our this->, that way we can
			// use anything from our parent form in our child one
			m_gConsole = new Console(this);
			m_gConsole.Show();
		}

		private void AcceptButton_Click(object sender, EventArgs e)
		{
			string strPath = "steam_appid.txt";
			string strText;

			// if there is no text in the "SteamAppID" text box, return
			if (SteamAppID.Text.Length == 0)
				return;

			if (m_gbIsSteamInitiated)
				CMemeworks.Shutdown();

			// if "steam_appid.txt" does not exist
			if (!File.Exists(strPath))
			{
				// create a new file named "steam_appid.txt" using the instance
				// we defined earlier, for StreamWriter
				// and then we use StreamWriter to put the supplied AppID from the
				// "SteamAppID" TextBox field, into the text file
				// this is required for SteamAPI to initiate
				using (m_gWriter = File.CreateText(strPath))
					m_gWriter.Write(SteamAppID.Text);

				strText = string.Format("AppID file not found, creating a new one and setting the AppID as: {0}\n", SteamAppID.Text);
				m_gConsole.MainConsole.AppendText(strText);
			}
			else
			{
				// if the file exists, delete that CUNT
				File.Create(strPath).Close();

				// then create a new one :)
				// and write the AppID to it again
				// there's better ways to clear a text file, I was just
				// having stupid issues, so I took the easy way out
				using (m_gWriter = File.CreateText(strPath))
					m_gWriter.Write(SteamAppID.Text);

				strText = string.Format("AppID file found, replacing with AppID: {0}\n", SteamAppID.Text);
				m_gConsole.MainConsole.AppendText(strText);
			}

			// using the wrapper we created to initiate the SteamAPI
			if (CMemeworks.Initiated())
			{
				// if it succeeds, set the global variable to true
				m_gbIsSteamInitiated = true;
			}
			else
			{
				// if it fails, 99% of the time it's because of the AppID, so we just print this
				// bullshit out
				// and then set the global variable to false, as a second measure
				m_gConsole.MainConsole.AppendText("Input a valid AppID into the supplied text box.\n");
				m_gbIsSteamInitiated = false;
			}
		}

		private void Fuck_Click(object sender, EventArgs e)
		{
			if (!m_gbIsSteamInitiated)
			{
				m_gConsole.MainConsole.AppendText("Steam API is not initiated, please input an AppID into the supplied text box.\n");
				return;
			}

			m_gConsole.MainConsole.AppendText(CMemeworks.RequestUserStats());
		}

		private void InviteButton_Click(object sender, EventArgs e)
		{
			if (!m_gbIsSteamInitiated)
			{
				m_gConsole.MainConsole.AppendText("Steam API is not initiated, please input an AppID into the supplied text box.\n");
				return;
			}

			m_gConsole.MainConsole.AppendText(CMemeworks.FakeInvite(TargetInput.Text, ConnectInput.Text));
		}

		private void UnlockAllAchievements_Click(object sender, EventArgs e)
		{
			if (!m_gbIsSteamInitiated)
			{
				m_gConsole.MainConsole.AppendText("Steam API is not initiated, please input an AppID into the supplied text box.\n");
				return;
			}

			m_gConsole.MainConsole.AppendText(CMemeworks.GetAllAchievements());
		}

		private void LockAllAchievements_Click(object sender, EventArgs e)
		{
			if (!m_gbIsSteamInitiated)
			{
				m_gConsole.MainConsole.AppendText("Steam API is not initiated, please input an AppID into the supplied text box.\n");
				return;
			}

			m_gConsole.MainConsole.AppendText(CMemeworks.ClearAllAchievements());
		}
	}

	class CMain
	{
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}

