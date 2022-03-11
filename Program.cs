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

        public static void PlayGame()
        {

            const int StartingStake = 100;
            const int BetPerGame = 1;

            Gamblers gambler1 = new Gamblers(StartingStake);
            int Gamblers_Stake = gambler1.Gamblers_stake;

            Random random = new Random();
            int WinOrLoose = random.Next(0, 2);
            switch (WinOrLoose)
            {
                case 0:
                    Gamblers_Stake = Gamblers_Stake - BetPerGame;
                    break;
                case 1:
                    Gamblers_Stake = Gamblers_Stake + BetPerGame;
                    break;
            }

            Console.WriteLine(Gamblers_Stake);

        }
    }
}







