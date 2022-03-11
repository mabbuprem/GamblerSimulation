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

            const int STARTING_STAKE = 100;
            const int BET_PER_GAME = 1;
            const int WIN = 1;
            const int LOOSE = 0;
            int NoOfBets = 0;

            Gamblers gambler1 = new Gamblers(STARTING_STAKE);
            int Gamblers_Stake = gambler1.Gamblers_stake;
            while (Gamblers_Stake > 50 && Gamblers_Stake < 150)
            {
                Random random = new Random();
                int WinOrLoose = random.Next(0, 2);
                switch (WinOrLoose)
                {
                    case LOOSE:
                        Gamblers_Stake = Gamblers_Stake - BET_PER_GAME;
                        break;
                    case WIN:
                        Gamblers_Stake = Gamblers_Stake + BET_PER_GAME;
                        break;
                    default:
                        break;
                }
                NoOfBets++;
            }
            Console.WriteLine(Gamblers_Stake);

        }
    }
}







