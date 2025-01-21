using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBike.bus
{
    public class DataCollection
    {
        private static List<Bike> listOfBikes = new List<Bike>();


        public static List<Bike> ListOfBikes
        {
            get { return listOfBikes; }

            set { listOfBikes = value; }
        }

        public static void Add(Bike newBike)
        {
            listOfBikes.Add(newBike);
        }

        public static void Remove(Bike newBike)
        {
            listOfBikes.Remove(newBike);
        }

        public static void RemoveAt(int currentIndex)
        {
            listOfBikes.RemoveAt(currentIndex);
        }

        public static void InsertAt(int currentIndex, Bike currentBike)
        {
            listOfBikes.Insert(currentIndex, currentBike);
        }

        public static void Clear() { }

        public static Bike Search(int key, EnumType type)
        {
            Bike foundBike = null;

            if (type == EnumType.MountainBike)
            {
                foundBike = new MountainBike();
            }

            else if (type == EnumType.RoadBike)
            {
                foundBike = new RoadBike();
            }

            else if (type == EnumType.ElectricBike)
            {
                foundBike = new ElectricBike();
            }

            else if (type == EnumType.FoldingBike)
            {
                foundBike = new FoldingBike();
            }


            foreach (Bike currentBike in listOfBikes)
            {
                if (currentBike.SerialNumber == key)
                {
                    foundBike = currentBike;
                }
            }
            return foundBike;
        }

        public static List<Bike> GetBikeList()
        {
            return listOfBikes;
        }

        public static List<MountainBike> GetMountainBikeList()
        {
            List<MountainBike> listOfMountainBikes = new List<MountainBike>();

            foreach (Bike currentBike in listOfBikes)
            {
                if (currentBike is MountainBike)
                {
                    MountainBike currentMountainBike = new MountainBike();
                    currentMountainBike = (MountainBike)currentBike;
                    listOfMountainBikes.Add(currentMountainBike);
                }
            }
            return listOfMountainBikes;
        }


        public static List<RoadBike> GetRoadBikeList()
        {
            List<RoadBike> listOfRoadBikes = new List<RoadBike>();

            foreach (Bike currentBike in listOfBikes)
            {
                if (currentBike is RoadBike)
                {
                    RoadBike currentRoadBike = new RoadBike();
                    currentRoadBike = (RoadBike)currentBike;
                    listOfRoadBikes.Add(currentRoadBike);
                }
            }
            return listOfRoadBikes;
        }

        public static List<ElectricBike> GetElectricBikeList()
        {
            List<ElectricBike> listOfElectricBike = new List<ElectricBike>();

            foreach (Bike currentBike in listOfBikes)
            {
                if (currentBike is ElectricBike)
                {
                    ElectricBike currentElectricBike = new ElectricBike();
                    currentElectricBike = (ElectricBike)currentBike;
                    listOfElectricBike.Add(currentElectricBike);
                }
            }
            return listOfElectricBike;
        }

        public static List<FoldingBike> GetFoldingBikeList()
        {
            List<FoldingBike> listOfFoldingBike = new List<FoldingBike>();

            foreach (Bike currentBike in listOfBikes)
            {
                if (currentBike is FoldingBike)
                {
                    FoldingBike currentFoldingBike = new FoldingBike();
                    currentFoldingBike = (FoldingBike)currentBike;
                    listOfFoldingBike.Add(currentFoldingBike);
                }
            }
            return listOfFoldingBike;
        }
    }
}
