using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //output text
            
            Console.WriteLine("What's ya name?\n");

            int playerScore = 0;
            string playerName = "Hit";

            playerName = Console.ReadLine();

            int add = 0;

            while (playerScore < 10)
            {
                Console.Write("Increment score: \n");
                add = Convert.ToInt32(Console.ReadLine());
                playerScore += add;
                Console.Write("Current score: \n");
                Console.WriteLine(playerScore);
            }
            
            
            Console.WriteLine("Score of " + playerName);
            Console.WriteLine(playerScore);

            Console.ReadLine();            
        }
    }
}
