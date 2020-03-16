using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerGui
{
    class Server
    {
        string jarPath;
        string workingDirectory;
        string[] arguments;

        public Server(string jarPath, params string[] arguments)
        {
            this.jarPath = jarPath;
            this.arguments = arguments;
            StringBuilder builder = new StringBuilder();
            string jarName = "";
            //-jar JARPATH nogui
            foreach (string directoryName in jarPath.Split('\\'))
            {
                if (directoryName.Contains(".jar"))
                {
                    jarName = "\\" + directoryName;
                    Console.WriteLine(directoryName);
                }
            }
            this.workingDirectory = this.jarPath.Replace(jarName, "");

        }
    }
}
