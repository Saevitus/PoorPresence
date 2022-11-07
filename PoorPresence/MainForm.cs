using DiscordRPC;
using Utilities;

namespace PoorPresence
{
    public partial class MainForm : Form
    {
        // global "Console" class instance
        // which we can use to interact with the 
        // RichTextBox that we have added to the form
        public Console? m_gConsole = default;

        StreamWriter? m_gWriter = default;

        Memeworks? m_gMemeworks = default;
        DiscordPoorPresence? m_gDiscordPresence = default;

        bool m_gbIsSteamInitiated = false;
        bool m_gbIsDiscordInitiated = false;


        private Config? cfg = default;

        public MainForm()
        {
            InitializeComponent();

            // creating the new instance of our console form
            // and supplying it with our thisptr, that way we can
            // use anything from our parent form in our child one
            m_gConsole = new Console(this);
            m_gConsole.Show();

            // create instances of memeworks and discord presence, feed thisptr so we can call m_gConsole! print func
            m_gMemeworks = new Memeworks(this);
            m_gDiscordPresence = new DiscordPoorPresence(this);

            // invokeclient loop, idk if this is *actually* needed tbh it doesnt seem to do much in this sense
            //if (m_gbIsDiscordInitiated) m_gDiscordPresence.InvokeClient();

            // might add some sort of default config saving for easier usage
            //RPDetailsText.Text = "test";

            //var m_gCfg = new Config();

            cfg = new Config(this);

            cfg.Read();

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string strPath = "steam_appid.txt";
            string strText;

            // if there is no text in the "SteamAppID" text box, return
            if (SteamAppID.Text.Length == 0)
                return;

            if (m_gbIsSteamInitiated)
                m_gMemeworks!.Shutdown();

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
                m_gConsole!.Print(strText);
            }
            else
            {
                // if the file exists, delete that CUNT
                File.Create(strPath).Close();

                // then create a new one :)
                // and Write the AppID to it again
                // there's better ways to clear a text file, I was just
                // having stupid issues, so I took the easy way out
                using (m_gWriter = File.CreateText(strPath))
                    m_gWriter.Write(SteamAppID.Text);

                strText = string.Format("AppID file found, replacing with AppID: {0}\n", SteamAppID.Text);
                m_gConsole!.Print(strText);
            }

            // using the wrapper we created to initiate the SteamAPI
            if (!m_gMemeworks!.Initialized())
            {
                // if it fails, 99% of the time it's because of the AppID, so we just print this
                // bullshit out
                // and then set the global variable to false, as a second measure
                m_gConsole!.Print("Input a valid AppID into the supplied text box.\n");
                m_gbIsSteamInitiated = false;
            }

            // if it succeeds, set the global variable to true
            m_gbIsSteamInitiated = true;
        }

        private void Fuck_Click(object sender, EventArgs e)
        {
            if (!m_gbIsSteamInitiated)
            {
                m_gConsole!.Print("Steam API is not initiated, please input an AppID into the supplied text box.\n");
                return;
            }

            m_gMemeworks!.RequestUserStats();
        }

        private void InviteButton_Click(object sender, EventArgs e)
        {
            if (!m_gbIsSteamInitiated)
            {
                m_gConsole!.Print("Steam API is not initiated, please input an AppID into the supplied text box.\n");
                return;
            }

            m_gMemeworks!.FakeInvite(TargetInput.Text, ConnectInput.Text);
        }

        private void UnlockAllAchievements_Click(object sender, EventArgs e)
        {
            if (!m_gbIsSteamInitiated)
            {
                m_gConsole!.Print("Steam API is not initiated, please input an AppID into the supplied text box.\n");
                return;
            }

            m_gMemeworks!.GetAllAchievements();
        }

        private void LockAllAchievements_Click(object sender, EventArgs e)
        {
            if (!m_gbIsSteamInitiated)
            {
                m_gConsole!.Print("Steam API is not initiated, please input an AppID into the supplied text box.\n");
                return;
            }

            m_gMemeworks!.ClearAllAchievements();
        }

        private void UnlockSetAchievements_Click(object sender, EventArgs e)
        {
            int iNum = Int32.Parse(NumOfAchievements.Text);

            if (!m_gbIsSteamInitiated)
            {
                m_gConsole!.Print("Steam API is not initiated, please input an AppID into the supplied text box.\n");
                return;
            }

            m_gMemeworks!.SetAchievementAmount(iNum);
        }

        private void RichButton_Click(object sender, EventArgs e)
        {
            if (!m_gbIsSteamInitiated)
            {
                m_gConsole!.Print("Steam API is not initiated, please input an AppID into the supplied text box.\n");
                return;
            }

            m_gMemeworks!.SetPoorPresence(StatusInput.Text, ScoreInput.Text);
        }

        // init discord api
        private void DiscordRPCButton_Click(object sender, EventArgs e)
        {
            if (DiscordAppID.Text.Length == 0)
                return;

            m_gbIsDiscordInitiated = m_gDiscordPresence!.Initialize(DiscordAppID.Text);

            if (!m_gbIsDiscordInitiated)
            {
                m_gConsole!.Print("Discord Client is not initiated, please input a valid AppID into the supplied text box.\n");
                return;
            }
        }

        // setting the rich presence
        private void SetDCRP_Click(object sender, EventArgs e)
        {
            if (!m_gbIsDiscordInitiated)
            {
                m_gConsole!.Print("Discord Client is not initiated, please input a valid AppID into the supplied text box.\n");
                return;
            }

            /* 
             * create new richpresence class & set it up with data input into the text boxes
             * we also create a new timestamps instance, so we can use that later for setting the timestamps(crazy)
             * we are passing the class into the set presence function straight away, as we have no need to access it otherwise
            */
            m_gDiscordPresence!.SetPresence(new RichPresence()
            {
                Details = RPDetailsText.Text,
                State = RPStateText.Text,
                Assets = new Assets()
                {
                    LargeImageKey = RPLargeImageText.Text,
                    //LargeImageText = "STEAMWORKS", (this is kinda pointless, but you can do it if you want, there's also SmallImageText
                    SmallImageKey = RPSmallImageText.Text
                },
                Timestamps = new Timestamps()
            });
        }

        // toggle the timestamp on and off, fairly straight forward 
        private void timestampToggle_Click(object sender, EventArgs e)
        {
            m_gDiscordPresence!.ToggleTimestamp();
        }

        /* 
         * saving the config, this is a fun one - pass a class straight into the config.write function with all the data,
         * that's stored in the text boxes.
        */
        private void saveCfg_Click(object sender, EventArgs e)
        {
            cfg!.Write(new PoorConfig
            {
                // steam shit
                steamAppID = SteamAppID.Text,
                fInviteName = TargetInput.Text,
                fInviteCon = ConnectInput.Text,
                rpStatus = StatusInput.Text,
                rpScore = ScoreInput.Text,

                // discord shit
                appID = DiscordAppID.Text,
                details = RPDetailsText.Text,
                state = RPStateText.Text,
                largeImage = RPLargeImageText.Text,
                smallImage = RPSmallImageText.Text,
            });

        }

        /* 
         * loading the saved config, does the reverse of the function above, takes the data out of the
         * saved file and sets the text box text to be the saved shit
        */
        private void loadCfg_Click(object sender, EventArgs e)
        {
            cfg!.Read();
            var dc = cfg.getDefaultCfg();

            // steam shit
            SteamAppID.Text = dc.steamAppID;
            TargetInput.Text = dc.fInviteName;
            ConnectInput.Text = dc.fInviteCon;
            StatusInput.Text = dc.rpStatus;
            ScoreInput.Text = dc.rpScore;

            // discord shit
            DiscordAppID.Text = dc.appID;
            RPDetailsText.Text = dc.details;
            RPStateText.Text = dc.state;
            RPLargeImageText.Text = dc.largeImage;
            RPSmallImageText.Text = dc.smallImage;
        }

        // clearing the config and setting the text boxes to the default start text
        private void clearCfg_Click(object sender, EventArgs e)
        {
            // same as before, passing the class as an argument like this as we don't need to access it
            cfg!.Write(new PoorConfig
            {
                steamAppID = "",
                fInviteName = "Target Name",
                fInviteCon = "Connect String",
                rpStatus = "Status",
                rpScore = "Score",
                appID = "AppID",
                details = "Details",
                state = "State",
                largeImage = "Large Image",
                smallImage = "Small Image"
            });

            // calling loadCfg as this will just set everything for me rather than writing the same code again
            loadCfg_Click(sender, e);
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