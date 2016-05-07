using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Interfaces
{
    public interface IAttacker
    {
        void AssignDriver(string driverName);
        bool Attack(Enemy enemy);
        void DriveForward();
        void DriveBackward();
        void DriveLeft();
        void DriveRight();
        void GetLocation();
    }
}
