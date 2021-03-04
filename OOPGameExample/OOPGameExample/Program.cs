using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player enters the game
            Goal.GoalAttained = false;
            Player newPlayer = new Player();
            newPlayer.PlayerHealth = 100;
            while (!Goal.GoalAttained)
            {

                Console.WriteLine("Enter a number between 1 and 3");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("You win!");
                        Goal.GoalAttained = true;
                        break;
                    case 2:
                        Console.WriteLine("Enemy Appears!");
                        Enemy badGuy = new Enemy();
                        badGuy.EnemyName = "Baddy";
                        badGuy.HealthPoints = 10;
                        newPlayer.PlayerHealth = newPlayer.PlayerHealth - badGuy.HealthPoints;
                        Console.WriteLine("You got hit! you now have " + newPlayer.PlayerHealth + " health points");
                        break;
                    case 3:
                        Console.WriteLine("You see a dark corridor. Keep moving.");
                        break;
                }

            }


        }
    }
}
