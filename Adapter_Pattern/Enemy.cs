using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class Enemy
    {
        int _strength;
        string _name;

        public Enemy(string name = "Unknow", int strength = 100)
        {
            _name = name;
            _strength = strength;
        }

        public int Strength
        {
            get
            {
                return _strength;
            }
        }

        public int Hit(int demageLevel)
        {
            if (_strength - demageLevel < 1)
                _strength = 0;
            else
                _strength -= demageLevel;
            return _strength;
        }
        public bool IsDestroyed {
            get
            {
                return _strength < 1;
            }
        }
    }
}
