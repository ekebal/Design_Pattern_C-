using System;

namespace Design_Patern_Command
{
    public class Client
    {
        static void Main(string[] args)
        {
            RecepteurImpl1 television = new RecepteurImpl1();
            RecepteurImpl2 radio = new RecepteurImpl2();

            ICommand cmd1 = new CommandA(television);
            ICommand cmd2 = new CommandB(television);
            ICommand cmd3 = new CommandC(radio);

            Invoquer telecommande = new Invoquer();
            telecommande.addNewCommand("A", cmd1);
            telecommande.addNewCommand("B", cmd2);
            telecommande.addNewCommand("C", cmd3);
            

            telecommande.invoquer("A");
            telecommande.invoquer("B");
            telecommande.invoquer("C");
            //telecommande.invoquer("D");

        }
    }
}
