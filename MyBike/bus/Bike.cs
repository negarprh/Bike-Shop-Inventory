using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyBike.bus
{
    [XmlInclude(typeof(MountainBike))]
    [XmlInclude(typeof(RoadBike))]
    [XmlInclude(typeof(ElectricBike))]
    [XmlInclude(typeof(FoldingBike))]

    public abstract class Bike : Object , IMovable, IPrintable
    {
        private int serialNumber;
        private string ? brand;
        private string? model;
        private double speed;
        private EnumColor color;        
        private EnumType type;
        private Date madeDate;
        private double maxSpeed;


        public int SerialNumber
        {
            get { return serialNumber; }
            set { this.serialNumber = value; }
        }
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double Speed
        {
            get { return this.speed; }
            set { this.speed = value; } 
        }

        public EnumColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public EnumType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public Date MadeDate
        {
            get { return this.madeDate; }
            set { this.madeDate = value; }
        }

        public double MaxSpeed
        {
            get { return this.maxSpeed; }
            set { this.maxSpeed = value; }
        }


        public Bike()
        {
            this.serialNumber = 0;
            this.brand = "Undefined";
            this.model = "Undefined";
            this.speed = 0;
            this.color = EnumColor.Undefined;
            this.type = EnumType.Undefined;
            this.madeDate = new Date();
            this.maxSpeed = 20.0;
        }

        public Bike(int serialNumber, string brand, string model, double speed, EnumColor color, EnumType type, Date madeDate, double maxSpeed)
        {
            this.serialNumber = serialNumber;
            this.brand = brand;
            this.model = model;
            this.speed = speed;
            this.color = color;
            this.type = type;
            this.madeDate = madeDate;
            this.maxSpeed = maxSpeed;
        }


        public virtual string GetState()
        {
            string state;

            state = this.serialNumber + " | " + this.brand + " | " + this.model + " | " + this.speed + " | " + this.color  + " | " + this.type + " | " + this.madeDate.GetDateState();

            return state;

        }

        public virtual double GetMaxSpeed()
        {
            return maxSpeed;
        }

        public abstract void SpeedUp();

        public abstract void SpeedUp(double newSpeed);



    }
}
