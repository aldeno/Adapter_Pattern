using Adapter_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class Tank : IAttacker
    {
        string _driver;
        Location _location;

        public Tank()
        {
            _driver = "Unknown";
            _location = new Location();
        }

        public void AssignDriver(string driverName)
        {
            _driver = driverName;
        }

        public bool Attack(Enemy enemy)
        {
            if (enemy == null)
            {
                Console.WriteLine("Enemy does not exist!");
                return false;
            }
            int demageLevel = new Random().Next(0, 50);
            enemy.Hit(demageLevel);

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"Attack strength: {demageLevel}");
            Console.WriteLine($"Enemy strength left: {enemy.Strength}");
            Console.WriteLine("Target is " + (enemy.IsDestroyed ? "" : "not") + " destroyed!");
            Console.WriteLine("----------------------------------------------------------");

            return enemy.IsDestroyed;
        }

        public void DriveBackward()
        {
            _location.X--;
            GetLocation();
        }

        public void DriveForward()
        {
            _location.X++;
            GetLocation();
        }

        public void DriveLeft()
        {
            _location.Y--;
            GetLocation();
        }

        public void DriveRight()
        {
            _location.Y++;
            GetLocation();
        }

        public void GetLocation()
        {
            Console.WriteLine($"Coordinates [{_location.X},{_location.Y}]");
        }
    }
}
