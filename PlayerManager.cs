using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerGui
{
    class PlayerManager
    {

        private string workingDirectory;
        private bool fileNotFound = false;

        public List<WhitelistedPlayer> whitelistedPlayers = new List<WhitelistedPlayer>();

        public PlayerManager(string workingDirectory)
        {
            this.workingDirectory = workingDirectory;

            this.whitelistedPlayers = File.Exists(workingDirectory + "\\whitelist.json") ? JsonConvert.DeserializeObject<List<WhitelistedPlayer>>(File.ReadAllText(workingDirectory + "\\whitelist.json")) : null;
            if (this.whitelistedPlayers == null)
            {
                this.fileNotFound = true;
            }
        }

        public bool FileNotFound()
        {
            return this.fileNotFound;
        }

        public void RetryFileParsing()
        {
            string jsonData;
            jsonData = File.ReadAllText(workingDirectory + "\\whitelist.json");
            this.whitelistedPlayers = File.Exists(workingDirectory + "\\whitelist.json") ? JsonConvert.DeserializeObject<List<WhitelistedPlayer>>(jsonData) : null;
        }

        public bool PlayerIsWhitelisted(string name)
        {
            if (this.whitelistedPlayers.Count == 0)
            {
                return false;
            }

            foreach (WhitelistedPlayer whitelistedPlayer in this.whitelistedPlayers)
            {
                if (whitelistedPlayer.name.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
