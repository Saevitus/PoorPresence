using System;
using System.Text;
using DiscordRPC;
using PoorPresence;
using Steamworks;

namespace Utilities
{
	public static class Util
	{
		// just a wrapper for Cosole.ReadKey(), for ease
		public static void WaitForInput() { System.Console.ReadKey(); }

        // loop function that takes an action delegate method so you can pass functions into it and have them looped
		// it just uses a timer which you can change the interval of looping


        public static void Loop(Action method, int interval)
		{
            var timer = new System.Windows.Forms.Timer();
            timer.Tick += (sender, args) =>
            {
                method();
            };

            timer.Interval = interval;
            timer.Start();
        }

	}

	public class Memeworks
	{
		private MainForm? m_gForm = default;

		public Memeworks(MainForm form) { m_gForm = form; }

		// initializes steam api
		public bool Initialized() { return SteamAPI.Init(); }

		public void Shutdown() { SteamAPI.Shutdown(); }

		public void RequestUserStats()
		{
			// initiate the StringBuilder class so we can use it
			// to concat strings, so the code looks nicer
			// and we define less variables
			StringBuilder strBuild = new StringBuilder();

			// if this succeeds, we format some text letting us
			// know that the request was successful
			// among other shit
			if (SteamUserStats.RequestCurrentStats())
			{
				// requesting the steam name of the currently logged in account
				//  to display in this string, just for aesthetics basically
				strBuild.AppendFormat("Sucessfully requested user statistics for user: {0}\n", SteamFriends.GetPersonaName());
				strBuild.AppendFormat(GetSteamID3());
				strBuild.AppendFormat(GetSteamLevel());
				strBuild.AppendFormat(GetFriendCount());
				strBuild.AppendFormat("Country associated with current IP Address: {0}\n", SteamUtils.GetIPCountry());
				strBuild.AppendFormat("Current language being used: {0}\n", SteamUtils.GetSteamUILanguage());

				// is the current steam account banned? Yes or no, simple answer.
				// we get this from the SteamApps interface, however this doesn't
				// display if game banned.
				// and there isn't a fucking function for that for some reason.
				strBuild.AppendFormat("Is VAC Banned: {0}\n", SteamApps.BIsVACBanned() ? "true" : "false");
			}
			else
			{
				// the request failed dumbshit
				strBuild.AppendFormat("Failed to request user statistics for user {0}\n", SteamFriends.GetPersonaName());
			}

			// returning the strings we formatted and built using
			// string builder ya
			m_gForm!.m_gConsole!.Print(strBuild.ToString());
		}

		public string GetSteamID3()
		{
			// fill out the CSteamID structure with our own SteamID
			// via the SteamUser interface
			CSteamID steamID = SteamUser.GetSteamID();

			// returning the required information from the CSteamID struct
			// to form the SteamID3
			// U = EUniverse, I exclude this, because it will always be 1.
			// {0} = EAccountType, this *should* always be 1, however, it depends on the account, so I get it just incase.
			// {1} = the AccountID, this is 32bits long, and is completely unique per account.
			// the output should be something like [U:1:XXXXXXXX]
			return string.Format("SteamID3: [U:{0}:{1}]\n", (int)steamID.GetEAccountType(), steamID.GetAccountID());
		}

		public void SetName(string strName)
		{
			SteamFriends.SetPersonaName(strName);
            m_gForm!.m_gConsole!.Print(string.Format("Set name to: {0}\n", strName));
		}

		public string GetSteamLevel()
		{
			int iSteamLevel = SteamUser.GetPlayerSteamLevel();
            return string.Format("Steam Level: {0}\n", iSteamLevel);
		}

		public string GetFriendCount()
		{
			// gets the current number of friends for the currently logged in
			// steam account via the SteamFriends interface, using the friend flag
			// k_EFriendFlagAll, this will display EVERYONE, pending invites, requests sent
			// blocked friends(including people which have been blocked and unfriended)
			int iFriends = SteamFriends.GetFriendCount(EFriendFlags.k_EFriendFlagImmediate);

            return string.Format("Friend Count: {0}\n", iFriends);
		}

		/*
		 * @strStatus = the status of the game you're currently in, while viewing
		 * the user's "game info" from the steam friendslist.
		 * @strScore = the game's score, and information on it, this is mostly for
		 * CSGO, however I'm sure if other games have this implemented, you could 
		 * modify the code for it.
		 */
		public void SetPoorPresence(string strStatus, string strScore)
		{
            /*
			 * this is basically all csgo specific shit, apart from status
			 * this information was found from Synraw
			 * while he was reverse engineering csgo,
			 * I'm sure if there is a game that has functionality like this, you could RE
			 * it and locate the required information to change it.
			 * 
			 * There has been an update to csgo that has added "#bcast_teamvsteammap"
			 * This allows us to use both status and score again.
			 * 
			 * I've left some stuff commented, if you want to play around with it.
			 */

            // this is the "status" you can view when you rightclick
            // a user in your steam friends and view their game info
            SteamFriends.ClearRichPresence();
            //SteamFriends.SetRichPresence("game:act", "offline");
			SteamFriends.SetRichPresence("game:mode", "competitive");
			SteamFriends.SetRichPresence("map", "de_dust2");

            //SteamFriends.SetRichPresence("status", strStatus); 
            //SteamFriends.SetRichPresence("score", strScore);

            SteamFriends.SetRichPresence("team1", strStatus);
			SteamFriends.SetRichPresence("team2", strScore);

            SteamFriends.SetRichPresence("steam_display", "#bcast_teamvsteammap");
            //SteamFriends.SetRichPresence("steam_display", "#bcast_roundn");
            //SteamFriends.SetRichPresence("steam_display", "#bcast_score");


            m_gForm!.m_gConsole!.Print(string.Format("Setting status to: {0}\nSetting score to: {1}\n", strStatus, strScore));
		}

		public void GetAchievementIDs()
		{
			uint iAchievements = SteamUserStats.GetNumAchievements();

			System.Console.WriteLine("Internal Achievement IDs: ");
			for (uint i = 0; i < iAchievements; i++)
			{
				string strName = SteamUserStats.GetAchievementName(i);
				System.Console.Write("  {0}{1}", strName, Environment.NewLine);
			}
		}

		public void SetAchievementAmount(int iNum)
		{
			for (uint i = 0; i < iNum; i++)
			{
				string strAchievement = SteamUserStats.GetAchievementName(i);
				SteamUserStats.SetAchievement(strAchievement);
			}
			if (SteamUserStats.StoreStats())
			{
                m_gForm!.m_gConsole!.Print(string.Format("Successfully unlocked {0} Achievement(s)!\n", iNum));
			}
            m_gForm!.m_gConsole!.Print("Failed to unlock achievements.\n");
		}

		public void GetAllAchievements()
		{
			uint iAchievements = SteamUserStats.GetNumAchievements();

			for (uint i = 0; i < iAchievements; i++)
			{
				string strAchievement = SteamUserStats.GetAchievementName(i);
				SteamUserStats.SetAchievement(strAchievement);
			}
			if (SteamUserStats.StoreStats())
			{
                m_gForm!.m_gConsole!.Print(string.Format("Successfully unlocked {0} Achievement(s)!\n", iAchievements));
			}
            m_gForm!.m_gConsole!.Print("Failed to unlock achievements.\n");
		}

		public void ClearAllAchievements()
		{
			uint iAchievements = SteamUserStats.GetNumAchievements();

			for (uint i = 0; i < iAchievements; i++)
			{
				string strAchievement = SteamUserStats.GetAchievementName(i);
				SteamUserStats.ClearAchievement(strAchievement);
			}
			if (SteamUserStats.StoreStats())
			{
                m_gForm!.m_gConsole!.Print(string.Format("Successfully cleared {0} Achievement(s)!\n", iAchievements));
			}
            m_gForm!.m_gConsole!.Print("Failed to clear achievements.\n");
		}

		public void FakeInvite(string strTargetName, string strConnectString)
		{
			int iFriendCount = SteamFriends.GetFriendCount(EFriendFlags.k_EFriendFlagImmediate);

			for (int a = 0; a < iFriendCount; a++)
			{
				CSteamID FriendID = SteamFriends.GetFriendByIndex(a, EFriendFlags.k_EFriendFlagImmediate);

				string strFriendName = SteamFriends.GetFriendPersonaName(FriendID);
				if (strFriendName.Equals(strTargetName))
				{
					EPersonaState EState = SteamFriends.GetFriendPersonaState(FriendID);
					if (EState == EPersonaState.k_EPersonaStateOffline || EState == EPersonaState.k_EPersonaStateSnooze)
                        m_gForm!.m_gConsole!.Print("The specified user was either Offline, or on Snooze.\n");

					bool bTest = SteamFriends.InviteUserToGame(FriendID, strConnectString);
					if (bTest)
                        m_gForm!.m_gConsole!.Print("Invite sent with specified launch parameters.\n");
					else
                        m_gForm!.m_gConsole!.Print("Failed to send invite with specified launch parameters.\n");
				}
			}
            m_gForm!.m_gConsole!.Print("Failed to find friend, ensure you have them added, and you're supplying the correct name.\n");
		}
	}

    public struct RpData
    {
        public string details, state, largeImage, smallImage;
		public DateTime timestamp;
    }

    public class DiscordPoorPresence
	{
		private MainForm? m_gForm = default;
        private DiscordRpcClient? client = default;

        public DiscordPoorPresence(MainForm form) { m_gForm = form;	}

        public bool Initialize(string appID)
		{
			if (client != null)
				client.Deinitialize();

            // no need for sanity check as it's done in the init button
            client = new DiscordRpcClient(appID);

            client.OnReady += (sender, e) =>
            {
                m_gForm!.m_gConsole!.Print(string.Format("Received Ready from user {0}\n", e.User.Username));
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                m_gForm!.m_gConsole!.Print(string.Format("Received Update! {0}\n", e.Presence));
            };

            return client.Initialize();
        }

        public void SetDiscordPoorPresence(RpData data)
		{
            var rp = new RichPresence()
			{
                Details = data.details,
                State = data.state,
                Assets = new Assets()
                {
                    LargeImageKey = data.largeImage,
                    //LargeImageText = "STEAMWORKS",
                    SmallImageKey = data.smallImage
                },
                Timestamps = new Timestamps()
                {
                    Start = data.timestamp
                    //End = 
                }

            };

			//client.ClearPresence();
            client!.SetPresence(rp);
        }


        public void InvokeClient()
        {
			Util.Loop(() => client!.Invoke(), 150);
        }
    }


}
