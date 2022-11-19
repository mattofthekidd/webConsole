using System.Collections.Generic;

namespace webConsole.Services {
    
    public interface IMainService {

        public string runCommand(string command, IEnumerable<string> options);
        public List<string> help(string command);
    }
    public class MainService : IMainService {
        public string runCommand(string command, IEnumerable<string> options) {
            
            return "";
        }

        public List<string> help(string command) {

            var resyu
            return ;
        }
    }
}
