using Adapter_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAttacker attacker = null;
            Enemy enemy = new Enemy("Great Warior", new Random().Next(40, 200));

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(" - Use arrow keys for move!");
            Console.WriteLine(" - Use space for attack!");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Press 1. for robot");
            Console.WriteLine("Press 2. for tank");

            ConsoleKey choosenWeapon;

            do
            {
                choosenWeapon = Console.ReadKey(true).Key;

                if (choosenWeapon == ConsoleKey.NumPad1 || choosenWeapon == ConsoleKey.D1)
                    attacker = new RobotAdapter(new Robot());
                else if (choosenWeapon == ConsoleKey.NumPad2 || choosenWeapon == ConsoleKey.D2)
                    attacker = new Tank();
                else
                    Console.WriteLine("Selected weapon does not exist, try again!");
            } while (choosenWeapon != ConsoleKey.NumPad1 && choosenWeapon != ConsoleKey.NumPad2
                        && choosenWeapon == ConsoleKey.D1 && choosenWeapon == ConsoleKey.D2);


            ConsoleKey pressedKey;
            do
            {
                pressedKey = Console.ReadKey(true).Key;
                switch (pressedKey)
                {
                    case ConsoleKey.UpArrow:
                        attacker.DriveForward();
                        break;
                    case ConsoleKey.DownArrow:
                        attacker.DriveBackward();
                        break;
                    case ConsoleKey.RightArrow:
                        attacker.DriveRight();
                        break;
                    case ConsoleKey.LeftArrow:
                        attacker.DriveLeft();
                        break;
                    case ConsoleKey.Spacebar:
                        attacker.Attack(enemy);
                        break;
                }

            } while (pressedKey != ConsoleKey.Escape);
        }
    }
}
