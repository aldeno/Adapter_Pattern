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

        public void HitWithHand()
        {
            Console.WriteLine($"I have hit the enemy. Demage level is: {new Random().Next(1,50)}");
        }

        public void WalkBackward()
        {
            throw new NotImplementedException();
        }

        public void WalkForward()
        {
            throw new NotImplementedException();
        }

        public void WalkLeft()
        {
            throw new NotImplementedException();
        }

        public void WalkRight()
        {
            throw new NotImplementedException();
        }
    }
}
