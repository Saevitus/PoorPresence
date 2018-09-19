using System;
using System.Text;
using Steamworks;

namespace Utilities
{
	public class CUtilities
	{
		// just a wrapper for Cosole.ReadKey(), for ease
		public static void WaitForInput() { Console.ReadKey(); }

	}

	public class CMemeworks
	{
		// initializes steam api
		public static bool Initiated() { return SteamAPI.Init(); }
		
		public static void Shutdown() { SteamAPI.Shutdown(); }

		public static string RequestUserStats()
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
			return strBuild.ToString();
		}

		public static string GetSteamID3()
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

		public static string SetName(string strName)
		{
			SteamFriends.SetPersonaName(strName);
			return string.Format("Set name to: {0}\n", strName);
		}

		public static string GetSteamLevel()
		{
			int iSteamLevel = SteamUser.GetPlayerSteamLevel();
			return string.Format("Steam Level: {0}\n", iSteamLevel);
		}

		public static string GetFriendCount()
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
		public static string SetPoorPresence(string strStatus, string strScore)
		{
			/*
			 * this is basically all csgo specific shit, apart from status
			 * this information was found from Synraw
			 * while he was reverse engineering csgo,
			 * I'm sure if there is a game that has functionality like this, you could RE
			 * it and locate the required information to change it.
			 */

			// this is the "status" you can view when you rightclick
			// a user in your steam friends and view their game info
			SteamFriends.SetRichPresence("status", strStatus);
			SteamFriends.SetRichPresence("game:act", "offline");
			SteamFriends.SetRichPresence("game:mode", "competitive");
			SteamFriends.SetRichPresence("game:mapgroupname", "mg_active");
			SteamFriends.SetRichPresence("game:map", "random");
			SteamFriends.SetRichPresence("game:score", strScore);
			SteamFriends.SetRichPresence("game:server", "competitive");
			SteamFriends.SetRichPresence("steam_display", "#display_GameKnownMapScore");

			return string.Format("Setting status to: {0}\nSetting score to: {1}\n", strStatus, strScore);
		}

		public static void GetAchievementIDs()
		{
			uint iAchievements = SteamUserStats.GetNumAchievements();

			Console.WriteLine("Internal Achievement IDs: ");
			for (uint i = 0; i < iAchievements; i++)
			{
				string strName = SteamUserStats.GetAchievementName(i);
				Console.Write("  {0}{1}", strName, Environment.NewLine);
			}
		}

		public static string GetAllAchievements()
		{
			uint iAchievements = SteamUserStats.GetNumAchievements();

			for (uint i = 0; i < iAchievements; i++)
			{
				string strAchievement = SteamUserStats.GetAchievementName(i);
				SteamUserStats.SetAchievement(strAchievement);
			}
			if (SteamUserStats.StoreStats())
			{
				return string.Format("Successfully unlocked {0} Achievement(s)!\n", iAchievements);
			}
			return "Failed to unlock achievements.\n";
		}

		public static string ClearAllAchievements()
		{
			uint iAchievements = SteamUserStats.GetNumAchievements();

			for (uint i = 0; i < iAchievements; i++)
			{
				string strAchievement = SteamUserStats.GetAchievementName(i);
				SteamUserStats.ClearAchievement(strAchievement);
			}
			if (SteamUserStats.StoreStats())
			{
				return string.Format("Successfully cleared {0} Achievement(s)!\n", iAchievements);
			}
			return "Failed to clear achievements.\n";
		}

		public static string FakeInvite(string strTargetName, string strConnectString)
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
						return "The specified user was either Offline, or on Snooze.\n";

					bool bTest = SteamFriends.InviteUserToGame(FriendID, strConnectString);
					if (bTest)
						return "Invite sent with specified launch parameters.\n";
					else
						return "Failed to send invite with specified launch parameters.\n";
				}
			}
			return "Failed to find friend, ensure you have them added, and you're supplying the correct name.\n";
		}
	}
}
