using PoorPresence;
using System.Text.Json;

namespace Utilities
{
    /*
     * it's safe to say, I have no idea how to properly serialize and deserialize json files
     * I've never worked with this before and i'm not really a c# person anyway
     * we've got the defaultconfig class which contains all the strings for every text box
     * with getters and setters.
     */
    public class PoorConfig
    {
        // steam shit
        public string? steamAppID { get; set; }
        public string? fInviteName { get; set; }
        public string? fInviteCon { get; set; }
        public string? rpStatus { get; set; }
        public string? rpScore { get; set; }

        // discord shit
        public string? appID { get; set; }
        public string? details { get; set; }
        public string? state { get; set; }
        public string? largeImage { get; set; }
        public string? smallImage { get; set; }
    }
    /*
     * the main config class, we've got out private global variables, form which is unused for now, 
     * this was just used for logging purposes.
     */
    public class Config
    {
        private MainForm? m_gForm = default;
        private PoorConfig? m_gCfg = default;
        //private static FileStream cfgFile = default;

        private string? str = default;

        /*
         * init the config class with a ptr to the mainform
         * we open a filestream for config.json, the mode is openorcreate, so if there isn't a config.json
         * it'll create a new one, but if there is... you know what happens
         * we create a new streamreader for the filestream, and readtoend into the global string variable,
         * we do this so we can check the length of it, if there's nothing then we create a brand new json table(?)
         * using jsonserializer and serialize it to the opened filestream with a new defaultconfig class, with empty strings
         */
        public Config(MainForm form)
        {
            m_gForm = form;

            var fs = File.Open("config.json", FileMode.OpenOrCreate);
            var reader = new StreamReader(fs);
            str = reader.ReadToEnd();

            if (str.Length == 0)
            {
                JsonSerializer.Serialize<PoorConfig>(fs, new PoorConfig
                {
                    steamAppID = "",
                    fInviteName = "",
                    fInviteCon = "",
                    rpStatus = "",
                    rpScore = "",
                    appID = "",
                    details = "",
                    state = "",
                    largeImage = "",
                    smallImage = ""
                });
                fs.Close();
            }
            fs.Close();
        }

        // returns the global config var, so we can read the data from it
        public PoorConfig getDefaultCfg() { return m_gCfg!; }

        // opens the config.json and reads it to the global config var using deserialize
        public void Read()
        {
            var sr = new StreamReader(File.Open("config.json", FileMode.Open));
            str = sr.ReadToEnd();

            m_gCfg = JsonSerializer.Deserialize<PoorConfig>(str)!;

            sr.Close();
        }

        // basically the same as above, except this write the global config to the config.json
        public void Write(PoorConfig c)
        {
            m_gCfg = c;

            var fs = File.Open("config.json", FileMode.Create);

            JsonSerializer.Serialize<PoorConfig>(fs, m_gCfg);

            fs.Close();
        }
    }
}
