using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBike.bus
{
    public class FoldingBike : Bike
    {
        private int weight;
        EnumFrameMaterial frameMaterial;

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public EnumFrameMaterial FrameMaterial
        {
            get { return this.frameMaterial; }
            set { this.frameMaterial = value; }
        }

        public FoldingBike() : base()
        {
            this.weight = 0;
            this.frameMaterial = EnumFrameMaterial.Undefined;
        }

        public FoldingBike(int serialNumber, string brand, string model, int speed, EnumColor color, EnumType type, Date madeDate, double maxSpeed, int weight, EnumFrameMaterial frameMaterial) : base(serialNumber, brand, model, speed, color, type, madeDate, maxSpeed)
        {
            this.weight = weight;
            this.frameMaterial = frameMaterial;

        }
        public override string GetState()
        {
            string state;

            state = base.GetState() + " | " + this.weight + " | " + this.frameMaterial;

            return state;

        }

        public override string ToString()
        {
            string state;

            state = base.GetState() + " | " + this.weight + " | " + this.frameMaterial;

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

        public override double GetMaxSpeed()
        {

            return 30.0;
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
