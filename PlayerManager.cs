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

        public List<WhitelistedPlayer> whitelistedPlayers = new List<WhitelistedPlayer>();

        public PlayerManager(string workingDirectory)
        {
            this.workingDirectory = workingDirectory;

            string jsonData;
            jsonData = File.ReadAllText(workingDirectory + "\\whitelist.json");
            this.whitelistedPlayers = JsonConvert.DeserializeObject<List<WhitelistedPlayer>>(jsonData);
            Console.WriteLine(this.whitelistedPlayers[0].name);
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
