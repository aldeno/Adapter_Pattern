using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Interfaces
{
    public interface IRobot
    {
        void AssignMaster(string masterName);
        bool HitWithHand(Enemy enemy);
        void WalkForward();
        void WalkBackward();
        void WalkLeft();
        void WalkRight();
        void GetCurrentPosition();
    }
}
