
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Design_Patern_Command
{
    public class CommandB : ICommand
    {
        private RecepteurImpl1 recepteur;
        public CommandB(RecepteurImpl1 recepteur)
        {
            this.recepteur = recepteur;
        }
        public void Execute()
        {
            recepteur.action2();
        }
    }
}