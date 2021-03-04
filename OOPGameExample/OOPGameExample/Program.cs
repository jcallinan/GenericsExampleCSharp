﻿using System;
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
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("You win! Hit Enter to finish!");
                        Goal.GoalAttained = true;

                        Console.ReadLine();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("Enemy Appears!");
                        Enemy badGuy = new Enemy();
                        badGuy.EnemyName = "Baddy";
                        badGuy.HealthPoints = 10;
                        newPlayer.PlayerHealth = newPlayer.PlayerHealth - badGuy.HealthPoints;
                        Console.WriteLine("You got hit! you now have " + newPlayer.PlayerHealth + " health points");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("You see a dark corridor. Keep moving.");
                        break;
                    case 4:
                        // Let's go through all Console colors and set them as foreground  
                        foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
                        {
                            Console.ForegroundColor = color;
                            Console.Clear();
                            Console.WriteLine("Foreground color set to " + color);
                        }
                        Console.WriteLine("=====================================");
                        Console.ForegroundColor = ConsoleColor.White;
                        // Let's go through all Console colors and set them as background  
                        foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
                        {
                            Console.BackgroundColor = color;
                            Console.WriteLine("Background color set to " + color);
                        }
                        Console.WriteLine("=====================================");
                        // Restore original colors  
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }

            }


        }
    }
}
