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

        public List<WhitelistedPlayer> WhitelistedPlayers = new List<WhitelistedPlayer>();
        public List<Operator> Operators = new List<Operator>();

        public PlayerManager(string workingDirectory)
        {
            this.workingDirectory = workingDirectory;
            string filePath;

            filePath = workingDirectory + "\\whitelist.json";
            this.WhitelistedPlayers = File.Exists(filePath) ? JsonConvert.DeserializeObject<List<WhitelistedPlayer>>(File.ReadAllText(filePath)) : null;

            filePath = workingDirectory + "\\ops.json";
            this.Operators = File.Exists(filePath) ? JsonConvert.DeserializeObject<List<Operator>>(File.ReadAllText(filePath)) : null;

            if (this.WhitelistedPlayers == null || this.Operators == null)
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
            string filePath;

            filePath = workingDirectory + "\\whitelist.json";
            this.WhitelistedPlayers = File.Exists(filePath) ? JsonConvert.DeserializeObject<List<WhitelistedPlayer>>(File.ReadAllText(filePath)) : null;

            filePath = workingDirectory + "\\ops.json";
            this.Operators = File.Exists(filePath) ? JsonConvert.DeserializeObject<List<Operator>>(File.ReadAllText(filePath)) : null;
        }

        public bool PlayerIsWhitelisted(string name)
        {
            if (this.WhitelistedPlayers == null)
            {
                return false;
            }

            string jsonData = File.ReadAllText(workingDirectory + "\\whitelist.json");
            this.WhitelistedPlayers = JsonConvert.DeserializeObject<List<WhitelistedPlayer>>(jsonData);

            foreach (WhitelistedPlayer whitelistedPlayer in this.WhitelistedPlayers)
            {
                if (whitelistedPlayer.name.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }

        public bool PlayerIsOp(string name)
        {
            if (this.Operators == null)
            {
                return false;
            }

            string jsonData = File.ReadAllText(workingDirectory + "\\ops.json");
            this.Operators = JsonConvert.DeserializeObject<List<Operator>>(jsonData);

            foreach (Operator op in this.Operators)
            {
                if (op.name.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
