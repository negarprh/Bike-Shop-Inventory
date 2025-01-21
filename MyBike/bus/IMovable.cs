using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBike.bus
{
    public interface IMovable
    {
        public abstract double GetMaxSpeed();

        public abstract void SpeedUp(double newSpeed);
    }
}
