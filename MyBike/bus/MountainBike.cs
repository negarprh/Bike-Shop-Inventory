using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBike.bus
{

    public class MountainBike : Bike
    {
        private int heightFromGround;
        private EnumSuspension suspension;


        public int HeightFromGround
        {
            get { return this.heightFromGround; }
            set { this.heightFromGround = value; }
        }
        public EnumSuspension Suspension
        {
            get { return this.suspension; }
            set { this.suspension = value; }
        }

        public MountainBike() : base()
        {
            this.heightFromGround = 0;
            this.suspension = EnumSuspension.Undefined;
        }

        public MountainBike(int serialNumber, string brand, string model, int speed, EnumColor color, EnumType type, Date madeDate, double maxSpeed, int heightFromGround, EnumSuspension suspension) : base(serialNumber, brand, model, speed, color, type, madeDate, maxSpeed)
        {
            this.heightFromGround = heightFromGround;
            this.suspension = suspension;

        }
        public override string GetState()
        {
            string state;

            state = base.GetState() + " | " + this.heightFromGround + " | " + this.suspension;

            return state;

        }

        public override string ToString()
        {
            string state;

            state = base.GetState() + " | " + this.heightFromGround + " | " + this.suspension;

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
            if (GetMaxSpeed() >= (Speed + newSpeed) )
            {
                this.Speed = this.Speed + newSpeed;
            }
        }



    }
}
