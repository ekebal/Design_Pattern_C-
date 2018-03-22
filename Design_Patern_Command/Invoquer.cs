using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patern_Command
{
    public class Invoquer
    {
        private IDictionary<String, ICommand> commandes = new Dictionary<string, ICommand>();

        public void addNewCommand(string reference, ICommand cmd)
        {
            commandes.Add(reference, cmd);
        }
        public void invoquer(string reference)
        {
            ICommand cmd = commandes[reference];
            if (cmd != null) cmd.Execute();
        }
    }
}
