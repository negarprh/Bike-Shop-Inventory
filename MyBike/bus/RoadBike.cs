using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBike.bus
{
    public class RoadBike : Bike
    {
        private double seatHeight;


        public double SeatHeight
        {
            get { return this.seatHeight; }
            set { this.seatHeight = value; }
        }

        public RoadBike() : base()
        {
            this.seatHeight = 0;
        }

        public RoadBike(int serialNumber, string brand, string model, int speed, EnumColor color , EnumType type, Date madeDate, double maxSpeed, double seatHeight) : base(serialNumber, brand, model, speed, color, type, madeDate, maxSpeed)
        {
            this.seatHeight = seatHeight;

        }
        public override string GetState()
        {
            string state;

            state = base.GetState() + " | " + this.seatHeight;

            return state;
        }

        public override string ToString()
        {
            string state;

            state = base.GetState() + " | " + this.seatHeight;

            return state;
        }


        public override double GetMaxSpeed()
        {
           
            return 40.0;
        }

        public override void SpeedUp()
        {

            this.Speed = this.Speed + 1;

        }


        public override void SpeedUp(double newSpeed)
        {
            if (GetMaxSpeed() >= (Speed + newSpeed))
            {
                this.Speed = this.Speed + newSpeed;
            }
        }

    }
}
