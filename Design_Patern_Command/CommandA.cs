using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Design_Patern_Command
{
    public class CommandA : ICommand
    {
        private RecepteurImpl1 recepteur;
        public CommandA(RecepteurImpl1 recepteur)
        {
            this.recepteur = recepteur;
        }
        public void Execute()
        {
            recepteur.action1();
        }
    }
}