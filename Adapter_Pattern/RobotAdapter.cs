using Adapter_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class RobotAdapter : IAttacker
    {
        Robot _robot;
        public RobotAdapter(Robot robot)
        {
            _robot = robot;
        }

        public void AssignDriver(string driverName)
        {
            _robot.AssignMaster(driverName);
        }

        public bool Attack(Enemy enemy)
        {
            return _robot.HitWithHand(enemy);
        }

        public void DriveBackward()
        {
            _robot.WalkBackward();
        }

        public void DriveForward()
        {
            _robot.WalkForward();
        }

        public void DriveLeft()
        {
            _robot.WalkLeft();
        }

        public void DriveRight()
        {
            _robot.WalkRight();
        }
        public void GetLocation()
        {
            _robot.GetCurrentPosition();
        }
    }
}
