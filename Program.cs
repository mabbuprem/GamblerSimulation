using System;

namespace GamblerSimulation
{
    internal class Program
    {
        private int Gamblers_Stake;

        static void Main(string[] args)
        {
            Console.WriteLine("Gambler Simulation");

        }

        public void OlayGame()
        {
            Gamblers gambler1 = new Gamblers(100);
            int Gambler_Stake = gambler1.Gamlers_stake;
            for (int day = 0; Gambler_Stake >= 0; day++)
            {
                Gamblers_Stake--;
            }
        }
    }
}







