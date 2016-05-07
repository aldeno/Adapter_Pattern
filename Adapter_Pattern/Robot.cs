using Adapter_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class Robot : IRobot
    {
        string _master;
        Location _location;
        Enemy _enemy;

        public Robot()
        {
            _master = "NoMaster";
            _location = new Location();
        }

        public void AssignMaster(string masterName)
        {
            _master = masterName;
        }

        public bool HitWithHand(Enemy enemy)
        {
            if (enemy == null)
            {
                Console.WriteLine("Enemy does not exist!");
                return false;
            }
            int demageLevel = new Random().Next(0, 15);
            enemy.Hit(demageLevel);

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"Attack strength: {demageLevel}");
            Console.WriteLine($"Enemy strength left: {enemy.Strength}");
            Console.WriteLine("Target is " + (enemy.IsDestroyed ? "" : "not") + " destroyed!");
            Console.WriteLine("----------------------------------------------------------");

            return enemy.IsDestroyed;
        }

        public void WalkBackward()
        {
            _location.X--;
            GetCurrentPosition();
        }

        public void WalkForward()
        {
            _location.X++;
            GetCurrentPosition();
        }

        public void WalkLeft()
        {
            _location.Y--;
            GetCurrentPosition();
        }

        public void WalkRight()
        {
            _location.Y++;
            GetCurrentPosition();
        }

        public void GetCurrentPosition()
        {
            Console.WriteLine($"Coordinates [{_location.X},{_location.Y}]");
        }
    }
}
