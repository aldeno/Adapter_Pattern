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
                return false;
            int demageLevel = new Random().Next(0, 50);

            enemy.Hit(demageLevel);

            return enemy.IsDestroyed;
        }

        public void DriveBackward()
        {
            _location.X--;
        }

        public void DriveForward()
        {
            _location.X++;
        }

        public void DriveLeft()
        {
            _location.Y--;
        }

        public void DriveRight()
        {
            _location.X++;
        }
    }
}
