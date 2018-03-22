using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patern_Command
{
    public class CommandC : ICommand
    {
        private RecepteurImpl2 recepteur;
        public CommandC(RecepteurImpl2 recepteur)
        {
            this.recepteur = recepteur;
        }
        public void Execute()
        {
            recepteur.action3();
        }
    }
}
