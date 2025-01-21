using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBike.bus
{
    public class ElectricBike : Bike
    {

        private int batteryLifeHours;


        public int BatteryLifeHours
        {
            get { return this.batteryLifeHours; }
            set { this.batteryLifeHours = value; }
        }

        public ElectricBike() : base()
        {
            this.batteryLifeHours = 0;
        }

        public ElectricBike(int serialNumber, string brand, string model, int speed, EnumColor color, EnumType type, Date madeDate, double maxSpeed, int batteryLifeHours) : base(serialNumber, brand, model, speed, color, type, madeDate, maxSpeed) 
        {
            this.batteryLifeHours = batteryLifeHours;

        }
        public override string GetState()
        {
            string state;

            state = base.GetState() + " | " + this.batteryLifeHours;

            return state;

        }

        public override string ToString()
        {
            string state;

            state = base.GetState() + " | " + this.batteryLifeHours;

            return state;

        }

        //public override string? ToString()
        //{
        //    return base.ToString();
        //}


        public override void SpeedUp()
        {

            this.Speed = this.Speed + 1;

        }


        public override void SpeedUp(double newSpeed)
        {
            if (GetMaxSpeed() > (Speed + newSpeed))
            {
                this.Speed = this.Speed + newSpeed;
            }
        }


    }
}
