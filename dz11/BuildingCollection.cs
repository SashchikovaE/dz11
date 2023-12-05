using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    internal class BuildingCollection
    {
        private BuildingCollection[] buildings = new BuildingCollection[10];
        public BuildingCollection this[int index]
        {
            get
            {
                if (index >= 0 && index < buildings.Length)
                {
                    return buildings[index];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
