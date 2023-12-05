using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    internal class Building
    {
        private static int lastBuildingNumber = 0;

        private int buildingNumber;
        public int BuildingNumber 
        { 
            get 
            { 
                return buildingNumber; 
            } 
            set 
            {
                buildingNumber = value;
            } 
        }

        private int height;
        public int Height 
        { 
            get 
            { 
                return height; 
            } 
            set
            { 
                height = value; 
            }
        }

        private int floors;
        public int Floors 
        { 
            get 
            { 
                return floors; 
            }
            set
            {
                floors = value;
            }
        }

        private int apartments;
        public int Apartments 
        { 
            get 
            { 
                return apartments; 
            } 
            set
            {
                apartments = value;
            }
        }

        private int entrances;
        public int Entrances 
        { 
            get 
            { 
                return entrances; 
            } 
            set
            {
                entrances = value;
            }
        }
        public Building()
        {

        }
        public Building(int height, int floors, int apartments, int entrances)
        {
            buildingNumber = GenerateBuildingNumber();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }
        private static int GenerateBuildingNumber()
        {
            lastBuildingNumber++;
            return lastBuildingNumber;
        }
        public double CalculateFloorHeight()
        {
            return height / floors;
        }
        public int CalculateApartmentsPerEntrance()
        {
            return apartments / entrances;
        }
        public int CalculateApartmentsPerFloor()
        {
            return apartments / floors;
        }
    }
}
