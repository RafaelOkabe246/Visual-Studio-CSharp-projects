using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsStudy.Builder
{
    internal class Director
    {
        //Earth houses
        public void BuildRoundHouseForEarth(HouseBuilder builder)
        {
            builder.SetHouseShapeType(HouseShapeType.Round).SetEnvirommentType(EnvirommentType.Balanced);
        }

        public void BuildCubeHouseForEarth(HouseBuilder builder)
        {
            builder.SetHouseShapeType(HouseShapeType.Cube).SetEnvirommentType(EnvirommentType.Balanced);
        }

        //Mars houses
        public void BuildRoundHouseForMars(HouseBuilder builder)
        {
            builder.SetHouseShapeType(HouseShapeType.Round).SetEnvirommentType(EnvirommentType.Extreme);

        }
        public void BuildCubeHouseForMars(HouseBuilder builder)
        {
            builder.SetHouseShapeType(HouseShapeType.Cube).SetEnvirommentType(EnvirommentType.Extreme);

        }
    }
}
