using System.Collections.Generic;

namespace webConsole.Models {
    public class Command {
        public string name { get; }
        public string description { get; }
        public IEnumerable<string> options { get; }

        public string function { get; }
    }
}
